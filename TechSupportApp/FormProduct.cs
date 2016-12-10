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
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            if (rdoBtnView.Checked)
            {
                return;
            }
            if (!Validation.IsDecimal(txtVersion.Text))
            {
                return;
            }
            decimal version = Convert.ToDecimal(txtVersion.Text);
            if (Validation.IsValidProduct(txtProdCode.Text, txtName.Text, version, dateTimeProd.Value))
            {
                if (rdoBtnCreate.Checked)
                {
                    if (Validation.IsValidProduct(txtProdCode.Text, txtName.Text, version, dateTimeProd.Value))
                    {

                        Product prod = new Product();

                        prod.ProductCode = txtProdCode.Text;
                        prod.Name = txtName.Text;
                        prod.Version = Convert.ToDecimal(version);
                        prod.ReleaseDate = dateTimeProd.Value;

                        if (HelperDB.AddProduct(prod))
                        {
                            MessageBox.Show("Product Successfully added :)");
                        }
                        else
                        {
                            MessageBox.Show("Something went wrong :(");
                        }
                    }
                }
                else if (rdoBtnUpdate.Checked)
                {
                    if (cboProdCode.SelectedItem == null)
                    {
                        MessageBox.Show("Please select a Product Code...");
                        return;
                    }
                    Product prod = new Product();

                    prod.ProductCode = cboProdCode.Text;
                    prod.Name = txtName.Text;
                    prod.Version = version;
                    prod.ReleaseDate = dateTimeProd.Value;

                    if (HelperDB.UpdateProduct(prod))
                    {
                        MessageBox.Show("Product updated successfully :)");
                    }
                    else
                    {
                        MessageBox.Show("Product did not update :(");
                    }
                }
                else
                {
                    MessageBox.Show("Please select an option.");
                }
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void cboName_DropDown(object sender, EventArgs e)
        {
            cboName.Items.Clear();

            List<Product> prods = HelperDB.GetProds();
            foreach (Product product in prods)
            {
                cboName.Items.Add(product.Name);
            }
        }

        private void rdoBtnCreate_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBtnCreate.Checked)
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

        private void rdoBtnView_CheckedChanged(object sender, EventArgs e)
        {
            cboName.Visible = true;
            txtName.Visible = false;
            cboProdCode.Visible = true;
            txtProdCode.Visible = false;
            txtVersion.ReadOnly = true;
            dateTimeProd.Enabled = false;
            btnDeleteProd.Enabled = true;
        }

        private void btnDeleteProd_Click(object sender, EventArgs e)
        {
            if (cboProdCode.SelectedItem == null)
            {
                MessageBox.Show("Please select a Product Code...");
                return;
            }
            else if (cboName.SelectedItem == null)
            {
                MessageBox.Show("Please select a Product Name...");
                return;
            }

            Product prod = new Product();

            prod.ProductCode = cboProdCode.Text;
            prod.Name = cboName.Text;
            prod.Version = Convert.ToDecimal(txtVersion.Text);
            prod.ReleaseDate = dateTimeProd.Value;

            if (HelperDB.DeleteProduct(prod))
            {
                MessageBox.Show($"Product '{prod.Name}' has successfully been deleted :)");
            }
            else
            {
                MessageBox.Show("Something went wrong :|");
            }
        }

        private void cboProdCode_DropDown(object sender, EventArgs e)
        {
            cboProdCode.Items.Clear();

            List<Product> prods = HelperDB.GetProds();

            foreach (Product product in prods)
            {
                cboProdCode.Items.Add(product.ProductCode);
            }

        }

        private void cboName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product prod = HelperDB.GetProdObjectFromName(cboName.Text);

            cboProdCode.Text = prod.ProductCode;
            txtVersion.Text = prod.Version.ToString();
            dateTimeProd.Value = prod.ReleaseDate;
        }

        private void cboProdCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product prod = HelperDB.GetProdObjectFromCode(cboProdCode.Text);

            cboName.Text = prod.Name;
            txtName.Text = prod.Name;
            txtVersion.Text = prod.Version.ToString();
            dateTimeProd.Value = prod.ReleaseDate;
        }

        private void rdoBtnUpdate_CheckedChanged(object sender, EventArgs e)
        {
            cboProdCode.Visible = true;
            txtProdCode.Visible = false;
            cboName.Visible = false;
            txtName.Visible = true;
            txtVersion.ReadOnly = false;
            dateTimeProd.Enabled = true;
            btnDeleteProd.Enabled = false;
        }
    }
}
