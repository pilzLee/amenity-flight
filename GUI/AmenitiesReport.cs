using System;
using System.Windows.Forms;
using DAO;
using DTO;

namespace GUI
{
    public partial class AmenitiesReport : Form
    {
        ScheduleDAO schedule = new ScheduleDAO();
        AmenitiyTicketDAO at = new AmenitiyTicketDAO();
        public AmenitiesReport()
        {
            InitializeComponent();
        }

        private void AmenitiesReport_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMakeReport_Click(object sender, EventArgs e)
        {
            Schedules s = schedule.getFlight(txtFlightID.Text);
            txtFrom.Text = s.departure;
            txtTo.Text = s.arrival;
            //show amenities
            dgvReport.Rows.Clear();
            dgvReport.Rows.Add();
            dgvReport.Rows.Add();
          
            dgvReport.Rows[0].Cells["amenity"].Value = "Economy";
            dgvReport.Rows[0].Cells["Column1"].Value = at.getAmount(txtFlightID.Text, "Extra Blanket", 1);
            dgvReport.Rows[0].Cells["Column2"].Value = at.getAmount(txtFlightID.Text, "Next Seat Free", 1);
            dgvReport.Rows[0].Cells["Column3"].Value = at.getAmount(txtFlightID.Text, "Two Neighboring Seats Free", 1);
            dgvReport.Rows[0].Cells["Column4"].Value = at.getAmount(txtFlightID.Text, "Tablet Rental", 1);
            dgvReport.Rows[0].Cells["Column5"].Value = at.getAmount(txtFlightID.Text, "Laptop Rental", 1);
            dgvReport.Rows[0].Cells["Column6"].Value = at.getAmount(txtFlightID.Text, "Lounge Access", 1);
            dgvReport.Rows[0].Cells["Column7"].Value = at.getAmount(txtFlightID.Text, "Premium Headphones Rental", 1);
            dgvReport.Rows[0].Cells["Column8"].Value = at.getAmount(txtFlightID.Text, "Extra Bag", 1);
            dgvReport.Rows[0].Cells["Column9"].Value = at.getAmount(txtFlightID.Text, "Fast Checkin Lane", 1);
            dgvReport.Rows[0].Cells["Column10"].Value = at.getAmount(txtFlightID.Text, "Wi-Fi 250 mb", 1);
            // bussiness
            dgvReport.Rows[1].Cells["amenity"].Value = "Bussiness";
            dgvReport.Rows[1].Cells["Column1"].Value = at.getAmount(txtFlightID.Text, "Extra Blanket", 2);
            dgvReport.Rows[1].Cells["Column2"].Value = at.getAmount(txtFlightID.Text, "Next Seat Free", 2);
            dgvReport.Rows[1].Cells["Column3"].Value = at.getAmount(txtFlightID.Text, "Two Neighboring Seats Free", 2);
            dgvReport.Rows[1].Cells["Column4"].Value = at.getAmount(txtFlightID.Text, "Tablet Rental", 2);
            dgvReport.Rows[1].Cells["Column5"].Value = at.getAmount(txtFlightID.Text, "Laptop Rental", 2);
            dgvReport.Rows[1].Cells["Column6"].Value = at.getAmount(txtFlightID.Text, "Lounge Access", 2);
            dgvReport.Rows[1].Cells["Column7"].Value = at.getAmount(txtFlightID.Text, "Premium Headphones Rental", 2);
            dgvReport.Rows[1].Cells["Column8"].Value = at.getAmount(txtFlightID.Text, "Extra Bag", 2);
            dgvReport.Rows[1].Cells["Column9"].Value = at.getAmount(txtFlightID.Text, "Fast Checkin Lane", 2);
            dgvReport.Rows[1].Cells["Column10"].Value = at.getAmount(txtFlightID.Text, "Wi-Fi 250 mb", 2);
            //first class
            dgvReport.Rows[2].Cells["amenity"].Value = "First Class";
            dgvReport.Rows[2].Cells["Column1"].Value = at.getAmount(txtFlightID.Text, "Extra Blanket", 3);
            dgvReport.Rows[2].Cells["Column2"].Value = at.getAmount(txtFlightID.Text, "Next Seat Free", 3);
            dgvReport.Rows[2].Cells["Column3"].Value = at.getAmount(txtFlightID.Text, "Two Neighboring Seats Free", 3);
            dgvReport.Rows[2].Cells["Column4"].Value = at.getAmount(txtFlightID.Text, "Tablet Rental", 3);
            dgvReport.Rows[2].Cells["Column5"].Value = at.getAmount(txtFlightID.Text, "Laptop Rental", 3);
            dgvReport.Rows[2].Cells["Column6"].Value = at.getAmount(txtFlightID.Text, "Lounge Access", 3);
            dgvReport.Rows[2].Cells["Column7"].Value = at.getAmount(txtFlightID.Text, "Premium Headphones Rental", 3);
            dgvReport.Rows[2].Cells["Column8"].Value = at.getAmount(txtFlightID.Text, "Extra Bag", 3);
            dgvReport.Rows[2].Cells["Column9"].Value = at.getAmount(txtFlightID.Text, "Fast Checkin Lane", 3);
            dgvReport.Rows[2].Cells["Column10"].Value = at.getAmount(txtFlightID.Text, "Wi-Fi 250 mb", 3);
        }
    }
}
