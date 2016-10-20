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
            List<Customer> cust = HelperDB.GetAllCustomers();
            foreach (Customer customer in cust)
            {
                cboCustomerList.Items.Add(customer.Name);
            }
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
        }
    }
}
