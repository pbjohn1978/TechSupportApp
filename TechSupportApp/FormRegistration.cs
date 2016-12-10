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
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cboCustomers.SelectedItem == null)
            {
                MessageBox.Show("Please select a customer");
                return;
            }
            else if (cboProducts.SelectedItem == null)
            {
                MessageBox.Show("Please select a product");
                return;
            }

                Customer cust = HelperDB.GetCustObject(cboCustomers.Text);
            Product prod = HelperDB.GetProdObjectFromName(cboProducts.Text);

            if (HelperDB.AddRegistration(cust, prod, dateTimeRegDate.Value))
            {
                MessageBox.Show("Registration added Successfully");
            }
        }
        /// <summary>
        /// Created by: Christian
        /// Fills the customer combo box with the customer names.
        /// reused the code from the customer form. Thanks John! :)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboCustomers_DropDown(object sender, EventArgs e)
        {
            cboCustomers.Items.Clear();
            List<Customer> cust = HelperDB.GetAllCustomers();
            foreach (Customer customer in cust)
            {
                cboCustomers.Items.Add(customer.Name);
            }
        }

        /// <summary>
        /// Created by: Christian
        /// populates combo box with product names and version numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboProducts_DropDown(object sender, EventArgs e)
        {
            cboProducts.Items.Clear();
            List<Product> prod = HelperDB.GetProds();
            foreach (Product product in prod)
            {
                cboProducts.Items.Add(product.Name);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cboCustomers.SelectedItem == null)
            {
                MessageBox.Show("Please select a customer");
                return;
            }
            else if (cboProducts.SelectedItem == null)
            {
                MessageBox.Show("Please select a product");
                return;
            }

            Customer cust = HelperDB.GetCustObject(cboCustomers.Text);
            Product prod = HelperDB.GetProdObjectFromName(cboProducts.Text);
            Registration reg = HelperDB.GetRegObject(cust, prod);

            if (HelperDB.DeleteRegistration(reg))
            {
                MessageBox.Show("Registration successfully deleted.");
            }
            else
            {
                MessageBox.Show("Something went wrong :(");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxDisplay.Items.Clear();
            Customer cust = HelperDB.GetCustObject(cboCustomers.Text);

            List<Registration> registrations = HelperDB.GetRegistrations(cust);

            foreach (Registration reg in registrations)
            {
                listBoxDisplay.Items.Add($"{reg.CustomerID} \t {reg.ProductCode} \t {reg.RegistrationDate.ToShortDateString()}");
            }
        }

        private void btnViewRegsForProd_Click(object sender, EventArgs e)
        {
            listBoxDisplay.Items.Clear();
            Product prod = HelperDB.GetProdObjectFromName(cboProducts.Text);

            List<Registration> registrations = HelperDB.GetRegistrations(prod);

            foreach (Registration reg in registrations)
            {
                listBoxDisplay.Items.Add($"{reg.CustomerID} \t {reg.ProductCode} \t {reg.RegistrationDate.ToShortDateString()}");
            }
        }
    }
}
