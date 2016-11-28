using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupportApp.Classes;

namespace TechSupportApp
{
    public partial class FormIncidents : Form
    {
        public FormIncidents()
        {
            InitializeComponent();
        }

        private void cboIncCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PopulateIncidents()
        {
            cboIncCustomerName.Items.Clear();
            List<Incidents> incidents = HelperDB.GetIncidents();
            foreach (Incidents i in incidents)
            {
                cboIncCustomerName.Items.Add(i.CustomerName);
            }
        }

        private void FormIncidents_Load(object sender, EventArgs e)
        {
            PopulateIncidents();
        }

        private void dtpDateTicketClosed_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
