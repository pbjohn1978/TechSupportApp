using System;
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
                    
                    MessageBox.Show( GetTechnicianName() + " Deleted");
                    PopulateTechnicians();
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
            Technicians selectedTech = (Technicians)cboTechnicians.SelectedItem;
            return selectedTech.TechID;
        }

        private string GetTechnicianName() {
            Technicians selectedTech = (Technicians)cboTechnicians.SelectedItem;
            return selectedTech.Name;
        }

        private void btnAddTechnician_Click(object sender, EventArgs e)
        {

        }
    }
}
