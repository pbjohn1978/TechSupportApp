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
            //// TODO: This line of code loads data into the 'techSupportDataSet.Products' table. You can move, or remove it, as needed.
            //this.productsTableAdapter.Fill(this.techSupportDataSet.Products);
            //// TODO: This line of code loads data into the 'techSupportDataSet.Customers' table. You can move, or remove it, as needed.
            //this.customersTableAdapter.Fill(this.techSupportDataSet.Customers);

        }
        private void PopulateCustomers()
        {
            List<Incidents> incidents = HelperDB.GetIncidents();
            foreach (Incidents temp in incidents)
            {
                cboAllCustomersIncidentsForm.Items.Add(temp.CustomerName);
            }
        }

        private void cboAllCustomersIncidentsForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Incidents> incidents = HelperDB.GetIncidents();
            foreach (Incidents incident in incidents)
            {
                lblIDLabel.Text = "Customer ID:";
                lblNameLabel.Text = "Customer Name:";
                lblNameLabel.Text = GetSelectedCustomerID().ToString();
                lblName.Text = GetSelectedCustomeName().ToString();
               
            }
        }
        public int GetSelectedCustomerID()
        {
            return Convert.ToInt32(lblID.Text);
        }

        public string GetSelectedCustomeName()
        {
            Customer selectedCustomer = (Customer)cboAllCustomersIncidentsForm.SelectedItem;
            return selectedCustomer.Name;
        }

        private void btnAddNewIncident_Click(object sender, EventArgs e)
        {
            FormAddNewIncident addIncident = new FormAddNewIncident();
            addIncident.Show();
        }
    }
}
