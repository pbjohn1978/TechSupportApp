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
    public partial class FormIncident : Form
    {
        public FormIncident()
        {
            InitializeComponent();
        }

        private void FormIncident_Load(object sender, EventArgs e)
        {
            PopulateCustomers();
        }

        private void PopulateCustomers()
        {
            List<Customer> customers = HelperDB.GetCustomerForIncidents();
            foreach (Customer temp in customers)
            {
                cboCustomerListforIncidents.Items.Add(temp.Name);
            }
        }

        private void btnAddNewIncident_Click(object sender, EventArgs e)
        {
            FormAddNewIncident formAddNewIncident = new FormAddNewIncident();
            formAddNewIncident.Show();
        }

        private void cboCustomerListforIncidents_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Incidents> incidents = HelperDB.GetIncidents();
            foreach (Incidents incident in incidents)
            {
                lblCustomerIDLabel.Text = "Customer ID:";
                lblCustomerNameLabel.Text = "Customer Name:";
                lblIncidentCustomerID.Text = GetSelectedCustomerID().ToString();
                lblIncidentCustomerName.Text = GetSelectedCustomeName().ToString();
                lstProductsRegisteredToCustomer.Text = incident.ProductName.ToString() + " " + incident.Version;
            }
            
        }

        private object GetSelectedCustomeName()
        {
            throw new NotImplementedException();
        }

        private void btnViewRegisteredProductsIncidentForm(object sender, EventArgs e)
        {
            List<Incidents> incidents = HelperDB.GetIncidents();
            foreach (Incidents temp in incidents)
            {
                if(GetSelectedCustomerID() == temp.CustomerID)
                {

                }
            }
        }

        private int GetSelectedCustomerID()
        {
            throw new NotImplementedException();
        }
    }
}
