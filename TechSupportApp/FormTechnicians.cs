﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupportApp.Classes;

namespace TechSupportApp
{
    public partial class frmTechnicians : Form
    {
        public frmTechnicians()
        {
            InitializeComponent();
        }

        private void frmTechnicians_Load(object sender, EventArgs e)
        {
            PopulateTechnicians();
        }

        private void cboTechnicians_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Technicians> technicians = HelperDB.GetTechnicians();
            foreach (Technicians techs in technicians) {
                if (techs.Name.ToString().Equals(cboTechnicians.Text.ToString()))
                {
                    lblTechnicianID.Text = techs.TechID.ToString();
                    txtTechnicianName.Text = techs.Name.ToString();
                    txtTechnicianEmail.Text = techs.Email.ToString();
                    maskTechnicianPhone.Text = techs.Phone.ToString();
                }
            }
        }

        private void PopulateTechnicians() {
            cboTechnicians.Items.Clear();
            List<Technicians> technicians = HelperDB.GetTechnicians();
            foreach (Technicians t in technicians) {
                cboTechnicians.Items.Add(t.Name);
            }
        }

        private void btnDeleteTechnician_Click(object sender, EventArgs e)
        {
            if (cboTechnicians.SelectedIndex >= 0)
            {
                
                int selectedID = GetSelectedTechnicianID();
                bool isDeleteTechSuccessful = HelperDB.DeleteTechnician(selectedID);
                if (isDeleteTechSuccessful)
                {
                    
                    MessageBox.Show("Technician Deleted");
                    PopulateTechnicians();
                    ClearTextboxFields();
                    
                }
                else
                {
                    HelperDB.ErrorMessage("delete");
                }
            }
            else {
                MessageBox.Show("Technician must be selected");
            }
        }

        private int GetSelectedTechnicianID()
        {
            //Technicians selectedTech = (Technicians)cboTechnicians.SelectedItem;
            
            return Convert.ToInt32(lblTechnicianID.Text);
        }

        private string GetTechnicianName() {
            Technicians selectedTech = (Technicians)cboTechnicians.SelectedItem;
            return selectedTech.Name;
        }

        private void btnAddTechnician_Click(object sender, EventArgs e)
        {
            if (IncludesAllRequiredFields())
            {
                try
                {
                    Technicians addTech = new Technicians();
                    addTech.Name = txtTechnicianName.Text;
                    addTech.Email = txtTechnicianEmail.Text;
                    addTech.Phone = maskTechnicianPhone.Text;
                    if (Validation.IsValidTechnician(addTech))
                    {
                        HelperDB.AddTechnician(addTech);
                        MessageBox.Show(addTech.Name + " added to database");
                        PopulateTechnicians();
                        ClearTextboxFields();
                    }
                    else
                    {
                        MessageBox.Show("Technician was not added.");
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                DisplayErrorMessage();
            }
        }

        private static void DisplayErrorMessage()
        {
            MessageBox.Show("All fields are required");
        }

        private bool IncludesAllRequiredFields()
        {
            bool isValid = true;
            if (txtTechnicianName.Text == "")
            {
                isValid = false;
            }
            if (txtTechnicianEmail.Text == "")
            {
                isValid = false;
            }
            return isValid;
        }

        private void ClearTextboxFields()
        {
            cboTechnicians.Text = "Select Technician from list";
            lblTechnicianID.Text = "";
            txtTechnicianEmail.Clear();
            txtTechnicianName.Clear();
            maskTechnicianPhone.Clear();
        }

        private void btnUpdateTechnician_Click(object sender, EventArgs e)
        {
            if (IncludesAllRequiredFields())
            {
                Technicians updatedTech = new Technicians();
                try
                {
                    updatedTech.TechID = GetSelectedTechnicianID();
                    updatedTech.Name = txtTechnicianName.Text;
                    updatedTech.Email = txtTechnicianEmail.Text;
                    updatedTech.Phone = maskTechnicianPhone.Text;
                    if (Validation.IsValidTechnician(updatedTech))
                    {
                        HelperDB.UpdateTechnician(updatedTech);
                        MessageBox.Show(updatedTech.Name + " updated");
                        PopulateTechnicians();
                        ClearTextboxFields();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                DisplayErrorMessage();
            }
        }

        public void SetLabel()
        {
            
        }

        private void lblTechnicianID_Click(object sender, EventArgs e)
        {
            
        }
    }
}
