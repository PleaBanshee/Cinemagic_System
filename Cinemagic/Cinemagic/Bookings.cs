using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RandomProj;

namespace RandomProj
{
    public partial class Bookings_Movies : Form
    {
        public Bookings_Movies()
        {
            InitializeComponent();
        }

        private void Bookings_Movies_Load(object sender, EventArgs e)
        {
            cmbAge.Items.Add("General Audiences");
            cmbAge.Items.Add("PG-13");
            cmbAge.Items.Add("PG");
            cmbAge.Items.Add("Restricted Under 17");
            cmbAge.Items.Add("NC-17");
        }
    }
}
