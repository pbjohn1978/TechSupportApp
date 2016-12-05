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
    public partial class FormIncident : Form
    {
        public FormIncident()
        {
            InitializeComponent();
        }

        private void FormIncident_Load(object sender, EventArgs e)
        {
            List<Customer> customers = HelperDB.GetCustomerForIncidents();
            foreach (Customer temp in customers)
            {
                cboCustomerListforIncidents.Items.Add(temp);
            }
        }
    }
}
