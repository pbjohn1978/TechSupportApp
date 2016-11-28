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
        /// <summary>
        /// Created by: Christian
        /// opens registration form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegistrations_Click(object sender, EventArgs e)
        {
            FormRegistration reg = new FormRegistration();
            reg.Show();
        }
        /// <summary>
        /// created by: Christian 
        /// opens product form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProducts_Click(object sender, EventArgs e)
        {
            FormProduct prod = new FormProduct();
            prod.Show();
        }

        private void btnIncidents_Click(object sender, EventArgs e)
        {
            FormIncidents incidentForm = new FormIncidents();
            incidentForm.Show();
        }

        private void btnTechnicians_Click(object sender, EventArgs e)
        {
            FormTechnicians techFrom = new FormTechnicians();
            techFrom.Show();
        }
    }
}
