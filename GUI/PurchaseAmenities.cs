using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace GUI
{
    public partial class PurchaseAmenities : Form
    {
        FlightS flight = new FlightS();
        TicketsDAO ticket = new TicketsDAO();
        CabinTypesDAO cabinType = new CabinTypesDAO();
        AmenityCabinTypeDAO act = new AmenityCabinTypeDAO();
        AmenitiyTicketDAO at = new AmenitiyTicketDAO();
        AmenityDAO a = new AmenityDAO();
        List<Amenity> list = new List<Amenity>();
        public PurchaseAmenities()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void PurchaseAmenities_Load(object sender, EventArgs e)
        {

        }

        private void btnShowAmenities_Click(object sender, EventArgs e)
        {
            Ticket t = ticket.aTicket
                (int.Parse(cbxChooseYourFlights.SelectedItem.ToString().Substring
                (
                    0, cbxChooseYourFlights.SelectedItem.ToString().IndexOf(",")
                )));
            lblFullName.Text = t.Firstname + " " + t.Lastname;
            lblPassportNumber.Text = t.PassportNumber;
            CabinType c = cabinType.aCabinType(t.CabinTypeID);
            lblYourCabinClassIs.Text = c.Name;
            //show amenities
            checkAmenity.Items.Clear();

            //get amenities ticket
            for(int i = 0; i < at.listAmenity(t.ID).Count; i++)
            {
                Amenity x = a.aAmenity(at.listAmenity(t.ID)[i].AmenityID);
                if (x.Service == "Soft Drinks" || x.Service == "Wi-Fi 50 mb")
                {
                    checkAmenity.ValueMember = "ID";
                    checkAmenity.Items.Add(x.Service + "( $" + x.Price.ToString("#,##0") + ")", CheckState.Indeterminate);
                }
                else
                    checkAmenity.Items.Add(x.Service + "( $" + x.Price.ToString("#,##0") + ")", CheckState.Checked);
            }

            // get amenities cabintype
            for (int i = 0; i < act.listAmenity(c.ID).Count; i++)
            {
                Amenity x = a.aAmenity(act.listAmenity(c.ID)[i].AmenityID);
                if (checkAmenity.FindString(x.Service) == -1)
                {
                    if (x.Service == "Soft Drinks" || x.Service == "Wi-Fi 50 mb")
                    {
                        checkAmenity.ValueMember = "ID";
                        checkAmenity.Items.Add(x.Service + "( $" + x.Price.ToString("#,##0") + ")", CheckState.Indeterminate);
                    }
                    else
                        checkAmenity.Items.Add(x.Service + "( $" + x.Price.ToString("#,##0") + ")", CheckState.Unchecked);

                }

            }

            //get amentities cost
            int sum = 0;
            for (int i = 0; i < checkAmenity.Items.Count; i++)
            {
                if (checkAmenity.GetItemChecked(i))
                {
                    sum += int.Parse(checkAmenity.Items[i].ToString().
                        Substring(checkAmenity.Items[i].ToString().IndexOf('$') + 1,
                        checkAmenity.Items[i].ToString().IndexOf(')')
                        - checkAmenity.Items[i].ToString().IndexOf('$') - 1));
                }
            }
            lblItemsSelected.Text = sum.ToString();
            lblDutiesAndTaxes.Text = (int.Parse(lblItemsSelected.Text) * .05).ToString();
            lblTotalPayable.Text = (int.Parse(lblItemsSelected.Text) + double.Parse(lblDutiesAndTaxes.Text)).ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            cbxChooseYourFlights.Items.Clear();
            if (flight.flights(txtBookingReference.Text).Count == 0)
            {
                MessageBox.Show("The booking reference doesn't exist. Please, re-enter!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            for (int i = 0; i < flight.flights(txtBookingReference.Text).Count; i++)
            {
                string text = flight.flights(txtBookingReference.Text)[i].flightID
                    + ", " + flight.flights(txtBookingReference.Text)[i].flightNumber
                    + ", " + flight.flights(txtBookingReference.Text)[i].flightPlace
                    + ", " + flight.flights(txtBookingReference.Text)[i].flightDate
                    + ", " + flight.flights(txtBookingReference.Text)[i].flightTime;

                if (cbxChooseYourFlights.Items.Contains(text))
                {
                    MessageBox.Show("The booking reference has been entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else cbxChooseYourFlights.Items.Add(text);
            }

        }
        
        private void checkAmenity_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < checkAmenity.Items.Count; i++)
            {
                if (checkAmenity.GetItemChecked(i))
                {
                    sum += int.Parse(checkAmenity.Items[i].ToString().
                        Substring(checkAmenity.Items[i].ToString().IndexOf('$') + 1,
                        checkAmenity.Items[i].ToString().IndexOf(')')
                        - checkAmenity.Items[i].ToString().IndexOf('$') - 1));
                }
            }
            lblItemsSelected.Text = sum.ToString();
            lblDutiesAndTaxes.Text = (int.Parse(lblItemsSelected.Text)*.05).ToString();
            lblTotalPayable.Text = (int.Parse(lblItemsSelected.Text) + double.Parse(lblDutiesAndTaxes.Text)).ToString();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSaveAndConfirm_Click(object sender, EventArgs e)
        {
            Ticket t = ticket.aTicket
            (int.Parse(cbxChooseYourFlights.SelectedItem.ToString().Substring
            (
                0, cbxChooseYourFlights.SelectedItem.ToString().IndexOf(",")
            )));

            try
            {
                //delete all old amenities ticket
                at.deleteAll(t.ID);
                //insert
                for (int i = 0; i < checkAmenity.Items.Count; i++)
                {
                    if (checkAmenity.GetItemChecked(i))
                    {
                        string service = checkAmenity.Items[i].ToString().
                            Substring(0, checkAmenity.Items[i].ToString().IndexOf('('));
                        try
                        {
                            at.insertAmenityTicket(a.getByService(service).ID, t.ID);

                        }
                        catch (Exception e1)
                        {
                            MessageBox.Show(e1.ToString(), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        }
                    }
                }
                MessageBox.Show("Save changes successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e1)
            {

                MessageBox.Show(e1.ToString(), "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            
        }
    }
}
