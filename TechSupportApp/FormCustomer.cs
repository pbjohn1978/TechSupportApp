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
            ClearTextBoxes();
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
            btnUpdate.Enabled = true;
        }

        private void btnCustomerAddNew_Click(object sender, EventArgs e)
        {
            AddOrUpdatCustomerInfo();
        }
        
        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            if (HelperDB.DeleteCustomer(Convert.ToInt32(txtLabCustomerID.Text)))
            {
                MessageBox.Show("Customer has been deleted.");
                PopulateCustomerList();
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("There was a database connection issue.");
            }
        }
        
        private void PopulateCustomerList()
        {
            cboCustomerList.Items.Clear();
            List<Customer> cust = HelperDB.GetAllCustomers();
            foreach (Customer customer in cust)
            {
                cboCustomerList.Items.Add(customer.Name);
            }
            cboCustomerList.SelectedIndex = 0;
        }

        private void ClearTextBoxes()
        {
            txtLabCustomerID.Text = "";
            txtCustomerZip.Text = "";
            txtCustomerState.Text = "";
            txtCustomerPhone.Text = "";
            txtCustomerName.Text = "";
            txtCustomerEmail.Text = "";
            txtCustomerCity.Text = "";
            txtCustomerAddress.Text = "";
            btnCustomerDelete.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AddOrUpdatCustomerInfo();
        }


        private void AddOrUpdatCustomerInfo()
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
                cust.CustomerID = Convert.ToInt32(txtLabCustomerID.Text);
                isValid = Validation.IsValidCustomer(cust);
            }
            finally
            {
                if (isValid)
                {
                    bool isAdded = HelperDB.AddOrUpdateCustomerInDB(cust);
                    MessageBox.Show("The Customer was Updated.");
                    PopulateCustomerList();
                    ClearTextBoxes();
                }
                else
                {
                    MessageBox.Show("Please Check the inputted data and submit it again... I think there is a problem");
                }
            }
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            UpdateOrAddButtonSelect();
        }
        
        private void txtCustomerAddress_TextChanged(object sender, EventArgs e)
        {
            UpdateOrAddButtonSelect();
        }

        private void txtCustomerCity_TextChanged(object sender, EventArgs e)
        {
            UpdateOrAddButtonSelect();
        }

        private void txtCustomerState_TextChanged(object sender, EventArgs e)
        {
            UpdateOrAddButtonSelect();
        }

        private void txtCustomerZip_TextChanged(object sender, EventArgs e)
        {
            UpdateOrAddButtonSelect();
        }

        private void txtCustomerPhone_TextChanged(object sender, EventArgs e)
        {
            UpdateOrAddButtonSelect();
        }

        private void txtCustomerEmail_TextChanged(object sender, EventArgs e)
        {
            UpdateOrAddButtonSelect();
        }
        
        private void UpdateOrAddButtonSelect()
        {
            
        }
    }
}
