using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class testcheckbox : Form
    {
        AmenityCabinTypeDAO act = new AmenityCabinTypeDAO();
        AmenityDAO a = new AmenityDAO();
        CabinTypesDAO c = new CabinTypesDAO();
        public testcheckbox()
        {
            InitializeComponent();
            for(int i = 0; i<act.listAmenity(1).Count; i++)
            {
                Amenity x = a.aAmenity(act.listAmenity(1)[i].AmenityID);
                suacheck.Items.Add(x.Service);
            }
        }
    }
}
