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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Code section by BeekerMeMeMe :) (john)
        /// this section handles a button click on the Customer button (btnCustomer)
        /// </summary>
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            FormCustomer cust = new FormCustomer();
            cust.Show();
        }

        private void btnRegistrations_Click(object sender, EventArgs e)
        {
            FormRegistration reg = new FormRegistration();
            reg.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            FormProduct prod = new FormProduct();
            prod.Show();
        }
    }
}
