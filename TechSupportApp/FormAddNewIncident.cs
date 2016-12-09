﻿using System;
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
    public partial class FormAddNewIncident : Form
    {
        public FormAddNewIncident()
        {
            InitializeComponent();
        }
        private void FormAddNewIncident_Load(object sender, EventArgs e)
        {
            PopulateCustomers();
            PopulateProducts();
            PopulateTechnicians();
        }

        private void PopulateTechnicians()
        {
            List<Technicians> techs = HelperDB.GetTechniansForIncidents();
            foreach(Technicians tech in techs)
            {
                cboSelectTechnicianToRegisterIncident.Items.Add(tech.Name);
            }
        }

        private void PopulateProducts()
        {
            List<Product> products = HelperDB.GetProductsForIncidents();
            foreach(Product product in products)
            {
                cboProductListToRegisterIncident.Items.Add(product.Name + " " + product.ProductCode);
            }
        }

        private void PopulateCustomers()
        {
            List<Customer> customers = HelperDB.GetCustomerForIncidents();
            foreach (Customer customer in customers)
            {
                cboSelectCustomerAddNewIncident.Items.Add(customer.Name);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNewIncidentRecord_Click(object sender, EventArgs e)
        {
            Incidents addNewIncident = new Incidents();
            bool isValid = true;
            try
            {

                addNewIncident.CustomerID = GetSelectedCustomerIndex();
                addNewIncident.ProductCode = cboProductListToRegisterIncident.Text;
                addNewIncident.TechID = GetSelectedTechID();
                addNewIncident.DateOpened = Convert.ToDateTime(mskAddDateOpened.Text).Date;
                addNewIncident.DateClosed = Convert.ToDateTime(mskAddDateResolved.Text).Date;
                addNewIncident.Title = txtAddIncidentTitle.Text;
                addNewIncident.Description = txtDescribeIncident.Text;
                if (isValid)
                {
                    HelperDB.AddIncident(addNewIncident);
                    FormIncident goToForm = new FormIncident();
                    goToForm.Show();
                    MessageBox.Show("Incident added to database");
                    
                }
                else
                {
                    MessageBox.Show("Incident was not added.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int GetSelectedTechID()
        {
            throw new NotImplementedException();
        }

        private int GetSelectedCustomerIndex()
        {
            throw new NotImplementedException();
        }


    }
}
