using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechSupportApp
{
    public partial class FormCustomerChoice : Form
    {
        public FormCustomerChoice()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            FormAddCustomer addcust = new FormAddCustomer();
            addcust.Show();
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            FormUpdateCustomer updateMe = new FormUpdateCustomer();
            updateMe.Show();
        }

        private void btnRetreiveCustomer_Click(object sender, EventArgs e)
        {
            FormCustomerLookUp retreiveMe = new FormCustomerLookUp();
            retreiveMe.Show();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            FormDeleteCustomer deleteMe = new FormDeleteCustomer();
            deleteMe.Show();
        }
    }
}
