using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupport;
using TechSupportApp.Classes;

namespace TechSupportApp
{
    public partial class FormIncidents : Form
    {
        public FormIncidents()
        {
            InitializeComponent();
        }

        private void FormIncidents_Load(object sender, EventArgs e)
        {
            PopulateCustomers();
        }
        private void PopulateCustomers()
        {
            List<Incidents> incidents = HelperDB.GetIncidents();
            cboAllCustomersIncidentsForm.DataSource = incidents;
            cboAllCustomersIncidentsForm.DisplayMember = "CustomerName";   
        }

        private void cboAllCustomersIncidentsForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Incidents> incidents = HelperDB.GetIncidents();
            
        }
        public int GetSelectedCustomerID()
        {
            Incidents selectedCustomer = (Incidents)cboAllCustomersIncidentsForm.SelectedItem;
            return selectedCustomer.CustomerID;
        }

        private void btnAddNewIncident_Click(object sender, EventArgs e)
        {
            FormAddNewIncident addIncident = new FormAddNewIncident();
            addIncident.Show();
        }

        private void btnUpdateIncident_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteSelectedIncident_Click(object sender, EventArgs e)
        {

        }
    }
}
