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
            List<Product> prod = HelperDB.GetProdNames();
            foreach (Product product in prod)
            {
                cboProducts.Items.Add(product.Name + "Version: " + product.Version);
            }
        }
    }
}
