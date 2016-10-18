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
    public partial class FormCustomerLookUp : Form
    {
        public FormCustomerLookUp()
        {
            InitializeComponent();
        }

        private void FormCustomerLookUp_Load(object sender, EventArgs e)
        {
            List<Customer> customers = HelperDB.GetAllCustomers();
            foreach (Customer customer in customers)
            {
                CustomerDropDownList.Items.Add(customer.Name);
            }
        }

        private void CustomerDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Customer> customers = HelperDB.GetAllCustomers();
            foreach (Customer customer in customers)
            {
                if (customer.Name == CustomerDropDownList.Text)
                {
                    txtLabCustAddress.Text = customer.Address;
                    txtLabCustCity.Text = customer.City;
                    txtLabCustEmail.Text = customer.Email;
                    txtLabCustID.Text = customer.CustomerID.ToString();
                    txtLabCustName.Text = customer.Name;
                    txtLabCustPhone.Text = customer.Phone;
                    txtLabCustState.Text = customer.State;
                    txtLabCustZip.Text = customer.ZipCode;
                }
            }
        }
    }
}
