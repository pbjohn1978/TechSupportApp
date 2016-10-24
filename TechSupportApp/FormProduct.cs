﻿using System;
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
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cboName.Visible = false;
            txtName.Visible = true;
            cboProdCode.Visible = false;
            txtProdCode.Visible = true;
            txtVersion.ReadOnly = false;
            dateTimeProd.Enabled = true;
            btnDeleteProd.Enabled = false;
        }
    }
}
