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
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            PopulateCustomerList();
        }


        private void cboCustomerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Customer> cust = HelperDB.GetAllCustomers();
            foreach (Customer customer in cust)
            {
                if (customer.Name.ToString().Equals(cboCustomerList.Text.ToString()))
                {
                    txtCustomerAddress.Text = customer.Address;
                    txtCustomerCity.Text = customer.City;
                    txtCustomerEmail.Text = customer.Email;
                    txtCustomerName.Text = customer.Name;
                    txtCustomerPhone.Text = customer.Phone;
                    txtCustomerState.Text = customer.State;
                    txtCustomerZip.Text = customer.ZipCode;
                    txtLabCustomerID.Text = Convert.ToString(customer.CustomerID);
                }
            }
            btnCustomerDelete.Enabled = true;
        }

        private void btnCustomerAddNew_Click(object sender, EventArgs e)
        {
            bool isValid = false;
            Customer cust = new Customer();
            try
            {
                cust.Name = txtCustomerName.Text;
                cust.Address = txtCustomerAddress.Text;
                cust.City = txtCustomerCity.Text;
                cust.State = txtCustomerState.Text;
                cust.ZipCode = txtCustomerZip.Text;
                cust.Phone = txtCustomerPhone.Text;
                cust.Email = txtCustomerEmail.Text;
                isValid = Validation.IsValidCustomer(cust);
            }
            finally
            {
                if (isValid)
                {
                    bool isAdded = HelperDB.AddCustomerToDB(cust);
                }
                else
                {
                    MessageBox.Show("Please Check the inputted data and submit it again... I think there is a problem");
                }
            }
        }

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            if (HelperDB.DeleteCustomer(Convert.ToInt32(txtLabCustomerID.Text)))
            {
                MessageBox.Show("Customer is like deleted and stuff...");
                PopulateCustomerList();
            }
            else
            {
                MessageBox.Show("sorry... database connection issue... call IT... wait... we are IT... we should fix this... :)");
            }
        }
        
        private void PopulateCustomerList()
        {
            List<Customer> cust = HelperDB.GetAllCustomers();
            foreach (Customer customer in cust)
            {
                cboCustomerList.Items.Add(customer.Name);
            }
        }
    }
}
