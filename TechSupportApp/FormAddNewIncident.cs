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
    public partial class FormAddNewIncident : Form
    {
        public FormAddNewIncident()
        {
            InitializeComponent();
        }
        private void FormAddNewIncident_Load(object sender, EventArgs e)
        {
            PopulateCustomers();
            PopulateProducts();
            PopulateTechnicians();
        }

        private void PopulateTechnicians()
        {
            List<Technicians> techs = HelperDB.GetTechniansForIncidents();
            cboSelectTechnicianToRegisterIncident.DataSource = techs;
            cboSelectTechnicianToRegisterIncident.DisplayMember = "Name";
            
        }

        private void PopulateProducts()
        {
            List<Product> products = HelperDB.GetProductsForIncidents();
            cboProductListToRegisterIncident.DataSource = products;
            cboProductListToRegisterIncident.DisplayMember = "Name";  
        }

        private void PopulateCustomers()
        {
            List<Customer> customers = HelperDB.GetCustomerForIncidents();
            cboSelectCustomerAddNewIncident.DataSource = customers;
            cboSelectCustomerAddNewIncident.DisplayMember = "Name";
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNewIncidentRecord_Click(object sender, EventArgs e)
        {
            Incidents addNewIncident = new Incidents();

            if (AllFieldsValid())
            {
                try
                {

                    addNewIncident.CustomerID = GetSelectedCustomerIndex();
                    addNewIncident.ProductCode = GetSelectedProductCode();
                    addNewIncident.TechID = GetSelectedTechID();
                    addNewIncident.DateOpened = Convert.ToDateTime(mskAddDateOpened.Text).Date;
                    if (addNewIncident.DateClosed != null)
                    {
                        addNewIncident.DateClosed = Convert.ToDateTime(mskAddDateResolved.Text).Date;
                    }
                    addNewIncident.Title = txtAddIncidentTitle.Text;
                    addNewIncident.Description = txtDescribeIncident.Text;
                    //if (isValid)
                    //{
                    HelperDB.AddIncident(addNewIncident);
                    this.Close();
                    MessageBox.Show("Incident added to database");

                    //}
                    //else
                    //{
                    //    MessageBox.Show("Incident was not added.");
                    //}
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private bool AllFieldsValid()
        {
            if (txtAddIncidentTitle.Text == null || txtDescribeIncident.Text == null || mskAddDateOpened.Text == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void cboSelectCustomerAddNewIncident_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetSelectedCustomerIndex();
        }
        private int GetSelectedCustomerIndex()
        {
            Customer selectedCustomer = (Customer)cboSelectCustomerAddNewIncident.SelectedValue;
            return selectedCustomer.CustomerID;
        }

        private void cboProductListToRegisterIncident_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetSelectedProductCode();
        }
        private string GetSelectedProductCode()
        {
            Product selectedProduct = (Product)cboProductListToRegisterIncident.SelectedItem;
            return selectedProduct.ProductCode;
        }

        private int GetSelectedTechID()
        {
            Technicians selectedTech = (Technicians)cboSelectTechnicianToRegisterIncident.SelectedItem;
            return selectedTech.TechID;
        }

        private void cboSelectTechnicianToRegisterIncident_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetSelectedTechID();
        }
    }
}
