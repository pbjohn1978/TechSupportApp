namespace TechSupportApp
{
    partial class frmTechnicians
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboTechnicians = new System.Windows.Forms.ComboBox();
            this.lblTechnician = new System.Windows.Forms.Label();
            this.txtTechnicianName = new System.Windows.Forms.TextBox();
            this.txtTechnicianEmail = new System.Windows.Forms.TextBox();
            this.lblTechnicianName = new System.Windows.Forms.Label();
            this.lblTechnicianEmail = new System.Windows.Forms.Label();
            this.lblTechnicianPhone = new System.Windows.Forms.Label();
            this.btnAddTechnician = new System.Windows.Forms.Button();
            this.btnUpdateTechnician = new System.Windows.Forms.Button();
            this.btnDeleteTechnician = new System.Windows.Forms.Button();
            this.maskTechnicianPhone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // cboTechnicians
            // 
            this.cboTechnicians.FormattingEnabled = true;
            this.cboTechnicians.Location = new System.Drawing.Point(44, 44);
            this.cboTechnicians.Name = "cboTechnicians";
            this.cboTechnicians.Size = new System.Drawing.Size(265, 21);
            this.cboTechnicians.TabIndex = 0;
            this.cboTechnicians.Text = "Select Technician from List";
            this.cboTechnicians.SelectedIndexChanged += new System.EventHandler(this.cboTechnicians_SelectedIndexChanged);
            // 
            // lblTechnician
            // 
            this.lblTechnician.AutoSize = true;
            this.lblTechnician.Location = new System.Drawing.Point(44, 23);
            this.lblTechnician.Name = "lblTechnician";
            this.lblTechnician.Size = new System.Drawing.Size(65, 13);
            this.lblTechnician.TabIndex = 1;
            this.lblTechnician.Text = "Technicians";
            // 
            // txtTechnicianName
            // 
            this.txtTechnicianName.Location = new System.Drawing.Point(155, 96);
            this.txtTechnicianName.Name = "txtTechnicianName";
            this.txtTechnicianName.Size = new System.Drawing.Size(238, 20);
            this.txtTechnicianName.TabIndex = 1;
            // 
            // txtTechnicianEmail
            // 
            this.txtTechnicianEmail.Location = new System.Drawing.Point(155, 137);
            this.txtTechnicianEmail.Name = "txtTechnicianEmail";
            this.txtTechnicianEmail.Size = new System.Drawing.Size(238, 20);
            this.txtTechnicianEmail.TabIndex = 2;
            // 
            // lblTechnicianName
            // 
            this.lblTechnicianName.AutoSize = true;
            this.lblTechnicianName.Location = new System.Drawing.Point(55, 103);
            this.lblTechnicianName.Name = "lblTechnicianName";
            this.lblTechnicianName.Size = new System.Drawing.Size(94, 13);
            this.lblTechnicianName.TabIndex = 5;
            this.lblTechnicianName.Text = "Technician Name:";
            // 
            // lblTechnicianEmail
            // 
            this.lblTechnicianEmail.AutoSize = true;
            this.lblTechnicianEmail.Location = new System.Drawing.Point(58, 144);
            this.lblTechnicianEmail.Name = "lblTechnicianEmail";
            this.lblTechnicianEmail.Size = new System.Drawing.Size(91, 13);
            this.lblTechnicianEmail.TabIndex = 6;
            this.lblTechnicianEmail.Text = "Technician Email:";
            // 
            // lblTechnicianPhone
            // 
            this.lblTechnicianPhone.AutoSize = true;
            this.lblTechnicianPhone.Location = new System.Drawing.Point(52, 184);
            this.lblTechnicianPhone.Name = "lblTechnicianPhone";
            this.lblTechnicianPhone.Size = new System.Drawing.Size(97, 13);
            this.lblTechnicianPhone.TabIndex = 7;
            this.lblTechnicianPhone.Text = "Technician Phone:";
            // 
            // btnAddTechnician
            // 
            this.btnAddTechnician.Location = new System.Drawing.Point(47, 225);
            this.btnAddTechnician.Name = "btnAddTechnician";
            this.btnAddTechnician.Size = new System.Drawing.Size(88, 51);
            this.btnAddTechnician.TabIndex = 4;
            this.btnAddTechnician.Text = "Add New Technician";
            this.btnAddTechnician.UseVisualStyleBackColor = true;
            this.btnAddTechnician.Click += new System.EventHandler(this.btnAddTechnician_Click);
            // 
            // btnUpdateTechnician
            // 
            this.btnUpdateTechnician.Location = new System.Drawing.Point(185, 225);
            this.btnUpdateTechnician.Name = "btnUpdateTechnician";
            this.btnUpdateTechnician.Size = new System.Drawing.Size(84, 51);
            this.btnUpdateTechnician.TabIndex = 5;
            this.btnUpdateTechnician.Text = "Update Technician";
            this.btnUpdateTechnician.UseVisualStyleBackColor = true;
            this.btnUpdateTechnician.Click += new System.EventHandler(this.btnUpdateTechnician_Click);
            // 
            // btnDeleteTechnician
            // 
            this.btnDeleteTechnician.Location = new System.Drawing.Point(317, 225);
            this.btnDeleteTechnician.Name = "btnDeleteTechnician";
            this.btnDeleteTechnician.Size = new System.Drawing.Size(86, 51);
            this.btnDeleteTechnician.TabIndex = 6;
            this.btnDeleteTechnician.Text = "Delete Technician";
            this.btnDeleteTechnician.UseVisualStyleBackColor = true;
            this.btnDeleteTechnician.Click += new System.EventHandler(this.btnDeleteTechnician_Click);
            // 
            // maskTechnicianPhone
            // 
            this.maskTechnicianPhone.Location = new System.Drawing.Point(156, 184);
            this.maskTechnicianPhone.Mask = "(999) 000-0000";
            this.maskTechnicianPhone.Name = "maskTechnicianPhone";
            this.maskTechnicianPhone.Size = new System.Drawing.Size(86, 20);
            this.maskTechnicianPhone.TabIndex = 3;
            // 
            // frmTechnicians
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 306);
            this.Controls.Add(this.maskTechnicianPhone);
            this.Controls.Add(this.btnDeleteTechnician);
            this.Controls.Add(this.btnUpdateTechnician);
            this.Controls.Add(this.btnAddTechnician);
            this.Controls.Add(this.lblTechnicianPhone);
            this.Controls.Add(this.lblTechnicianEmail);
            this.Controls.Add(this.lblTechnicianName);
            this.Controls.Add(this.txtTechnicianEmail);
            this.Controls.Add(this.txtTechnicianName);
            this.Controls.Add(this.lblTechnician);
            this.Controls.Add(this.cboTechnicians);
            this.Name = "frmTechnicians";
            this.Text = "Technicians";
            this.Load += new System.EventHandler(this.frmTechnicians_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTechnicians;
        private System.Windows.Forms.Label lblTechnician;
        private System.Windows.Forms.TextBox txtTechnicianName;
        private System.Windows.Forms.TextBox txtTechnicianEmail;
        private System.Windows.Forms.Label lblTechnicianName;
        private System.Windows.Forms.Label lblTechnicianEmail;
        private System.Windows.Forms.Label lblTechnicianPhone;
        private System.Windows.Forms.Button btnAddTechnician;
        private System.Windows.Forms.Button btnUpdateTechnician;
        private System.Windows.Forms.Button btnDeleteTechnician;
        private System.Windows.Forms.MaskedTextBox maskTechnicianPhone;
    }
}