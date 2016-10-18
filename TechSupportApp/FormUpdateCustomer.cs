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
    public partial class FormUpdateCustomer : Form
    {
        public FormUpdateCustomer()
        {
            InitializeComponent();
        }

        private void FormUpdateCustomer_Load(object sender, EventArgs e)
        {
            List<Customer> customers = HelperDB.GetAllCustomers();
            foreach (Customer customer in customers)
            {
                cboCustomerDropDownList.Items.Add(customer.Name);
            }
        }

        private void cboCustomerDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Customer> customers = HelperDB.GetAllCustomers();
            foreach (Customer customer in customers)
            {
                if (customer.Name == cboCustomerDropDownList.Text)
                {
                    txtCustomerAddress.Text = customer.Address;
                    txtCustomerCity.Text = customer.City;
                    txtCustomerEmail.Text = customer.Email;
                    txtLabCustomerID.Text = customer.CustomerID.ToString();
                    txtLabCustomerName.Text = customer.Name;
                    txtCustomerPhone.Text = customer.Phone;
                    txtCustomerState.Text = customer.State;
                    txtCustomerZip.Text = customer.ZipCode;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isValid = CustomerValidator.IsValidCustomer(sender, e);
            if (isValid)
            {
                Customer cust = new Customer();
                cust.Address = txtCustomerAddress.Text;
                cust.Address = txtCustomerCity.Text;
                cust.Email = txtCustomerEmail.Text;
                cust.CustomerID = Convert.ToInt32(txtLabCustomerID.Text);
                cust.Name = txtLabCustomerName.Text;
                cust.Phone = txtCustomerPhone.Text;
                cust.State = txtCustomerState.Text;
                cust.ZipCode = txtCustomerZip.Text;
                if (HelperDB.AddCustomerToDB(cust))
                {
                    MessageBox.Show("Customer has Been Updated!");
                }
                else
                {
                    MessageBox.Show("There was a problem with connecting to the database... please try again later... umm... sorry...");
                }
            }
            else
            {
                MessageBox.Show("There is a problem with the changes made... Please review the changed data and resubmit the data.");
            }
            clearTextBoxes();
        }

        private void clearTextBoxes()
        {
            cboCustomerDropDownList.Text = @"Please Select a Customer To Update:";
            txtCustomerAddress.Text = "";
            txtCustomerCity.Text = "";
            txtCustomerEmail.Text = "";
            txtLabCustomerID.Text = "";
            txtLabCustomerName.Text = "";
            txtCustomerPhone.Text = "";
            txtCustomerState.Text = "";
            txtCustomerZip.Text = "";
        }
    }
}
