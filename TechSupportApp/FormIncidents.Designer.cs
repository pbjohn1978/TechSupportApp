namespace TechSupportApp
{
    partial class FormIncidents
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
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.cboIncCustomerName = new System.Windows.Forms.ComboBox();
            this.lblCustomersProducts = new System.Windows.Forms.Label();
            this.cboIncProducts = new System.Windows.Forms.ComboBox();
            this.lblTechnician = new System.Windows.Forms.Label();
            this.cboIncTecnician = new System.Windows.Forms.ComboBox();
            this.lblIssue = new System.Windows.Forms.Label();
            this.lblIncDescription = new System.Windows.Forms.Label();
            this.txtIncidentDescription = new System.Windows.Forms.TextBox();
            this.dtpDateTicketOpened = new System.Windows.Forms.DateTimePicker();
            this.lblDateTicketOpened = new System.Windows.Forms.Label();
            this.dtpDateTicketClosed = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveIncident = new System.Windows.Forms.Button();
            this.cboIncidentName = new System.Windows.Forms.ComboBox();
            this.chkAddNewIncident = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(83, 30);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(85, 13);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // cboIncCustomerName
            // 
            this.cboIncCustomerName.FormattingEnabled = true;
            this.cboIncCustomerName.Location = new System.Drawing.Point(195, 25);
            this.cboIncCustomerName.Name = "cboIncCustomerName";
            this.cboIncCustomerName.Size = new System.Drawing.Size(228, 21);
            this.cboIncCustomerName.TabIndex = 1;
            this.cboIncCustomerName.Text = "Select Customer";
            this.cboIncCustomerName.SelectedIndexChanged += new System.EventHandler(this.cboIncCustomerName_SelectedIndexChanged);
            // 
            // lblCustomersProducts
            // 
            this.lblCustomersProducts.AutoSize = true;
            this.lblCustomersProducts.Location = new System.Drawing.Point(11, 62);
            this.lblCustomersProducts.Name = "lblCustomersProducts";
            this.lblCustomersProducts.Size = new System.Drawing.Size(160, 13);
            this.lblCustomersProducts.TabIndex = 2;
            this.lblCustomersProducts.Text = "Customer\'s Registered Products:";
            // 
            // cboIncProducts
            // 
            this.cboIncProducts.FormattingEnabled = true;
            this.cboIncProducts.Location = new System.Drawing.Point(195, 58);
            this.cboIncProducts.Name = "cboIncProducts";
            this.cboIncProducts.Size = new System.Drawing.Size(228, 21);
            this.cboIncProducts.TabIndex = 3;
            this.cboIncProducts.Text = "Select Product";
            // 
            // lblTechnician
            // 
            this.lblTechnician.AutoSize = true;
            this.lblTechnician.Location = new System.Drawing.Point(62, 93);
            this.lblTechnician.Name = "lblTechnician";
            this.lblTechnician.Size = new System.Drawing.Size(109, 13);
            this.lblTechnician.TabIndex = 4;
            this.lblTechnician.Text = "Assigned Technician:";
            // 
            // cboIncTecnician
            // 
            this.cboIncTecnician.FormattingEnabled = true;
            this.cboIncTecnician.Location = new System.Drawing.Point(195, 91);
            this.cboIncTecnician.Name = "cboIncTecnician";
            this.cboIncTecnician.Size = new System.Drawing.Size(228, 21);
            this.cboIncTecnician.TabIndex = 5;
            this.cboIncTecnician.Text = "Select Technician";
            // 
            // lblIssue
            // 
            this.lblIssue.AutoSize = true;
            this.lblIssue.Location = new System.Drawing.Point(89, 126);
            this.lblIssue.Name = "lblIssue";
            this.lblIssue.Size = new System.Drawing.Size(79, 13);
            this.lblIssue.TabIndex = 6;
            this.lblIssue.Text = "Incident Name:";
            // 
            // lblIncDescription
            // 
            this.lblIncDescription.AutoSize = true;
            this.lblIncDescription.Location = new System.Drawing.Point(75, 164);
            this.lblIncDescription.Name = "lblIncDescription";
            this.lblIncDescription.Size = new System.Drawing.Size(93, 13);
            this.lblIncDescription.TabIndex = 8;
            this.lblIncDescription.Text = "Describe Incident:";
            // 
            // txtIncidentDescription
            // 
            this.txtIncidentDescription.Location = new System.Drawing.Point(195, 160);
            this.txtIncidentDescription.Multiline = true;
            this.txtIncidentDescription.Name = "txtIncidentDescription";
            this.txtIncidentDescription.Size = new System.Drawing.Size(457, 111);
            this.txtIncidentDescription.TabIndex = 9;
            // 
            // dtpDateTicketOpened
            // 
            this.dtpDateTicketOpened.Location = new System.Drawing.Point(195, 293);
            this.dtpDateTicketOpened.Name = "dtpDateTicketOpened";
            this.dtpDateTicketOpened.Size = new System.Drawing.Size(200, 20);
            this.dtpDateTicketOpened.TabIndex = 10;
            // 
            // lblDateTicketOpened
            // 
            this.lblDateTicketOpened.AutoSize = true;
            this.lblDateTicketOpened.Location = new System.Drawing.Point(61, 299);
            this.lblDateTicketOpened.Name = "lblDateTicketOpened";
            this.lblDateTicketOpened.Size = new System.Drawing.Size(107, 13);
            this.lblDateTicketOpened.TabIndex = 11;
            this.lblDateTicketOpened.Text = "Date Ticket Opened:";
            // 
            // dtpDateTicketClosed
            // 
            this.dtpDateTicketClosed.Location = new System.Drawing.Point(195, 322);
            this.dtpDateTicketClosed.Name = "dtpDateTicketClosed";
            this.dtpDateTicketClosed.Size = new System.Drawing.Size(200, 20);
            this.dtpDateTicketClosed.TabIndex = 12;
            this.dtpDateTicketClosed.ValueChanged += new System.EventHandler(this.dtpDateTicketClosed_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Date Ticket Closed";
            // 
            // btnSaveIncident
            // 
            this.btnSaveIncident.Location = new System.Drawing.Point(295, 360);
            this.btnSaveIncident.Name = "btnSaveIncident";
            this.btnSaveIncident.Size = new System.Drawing.Size(100, 53);
            this.btnSaveIncident.TabIndex = 14;
            this.btnSaveIncident.Text = "Save Incident";
            this.btnSaveIncident.UseVisualStyleBackColor = true;
            // 
            // cboIncidentName
            // 
            this.cboIncidentName.FormattingEnabled = true;
            this.cboIncidentName.Location = new System.Drawing.Point(357, 124);
            this.cboIncidentName.Name = "cboIncidentName";
            this.cboIncidentName.Size = new System.Drawing.Size(295, 21);
            this.cboIncidentName.TabIndex = 15;
            this.cboIncidentName.Text = "Select to Update an Incident";
            // 
            // chkAddNewIncident
            // 
            this.chkAddNewIncident.AutoSize = true;
            this.chkAddNewIncident.Location = new System.Drawing.Point(195, 127);
            this.chkAddNewIncident.Name = "chkAddNewIncident";
            this.chkAddNewIncident.Size = new System.Drawing.Size(111, 17);
            this.chkAddNewIncident.TabIndex = 16;
            this.chkAddNewIncident.Text = "Add New Incident";
            this.chkAddNewIncident.UseVisualStyleBackColor = true;
            // 
            // FormIncidents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 432);
            this.Controls.Add(this.chkAddNewIncident);
            this.Controls.Add(this.cboIncidentName);
            this.Controls.Add(this.btnSaveIncident);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDateTicketClosed);
            this.Controls.Add(this.lblDateTicketOpened);
            this.Controls.Add(this.dtpDateTicketOpened);
            this.Controls.Add(this.txtIncidentDescription);
            this.Controls.Add(this.lblIncDescription);
            this.Controls.Add(this.lblIssue);
            this.Controls.Add(this.cboIncTecnician);
            this.Controls.Add(this.lblTechnician);
            this.Controls.Add(this.cboIncProducts);
            this.Controls.Add(this.lblCustomersProducts);
            this.Controls.Add(this.cboIncCustomerName);
            this.Controls.Add(this.lblCustomerName);
            this.Name = "FormIncidents";
            this.Text = "Incidents";
            this.Load += new System.EventHandler(this.FormIncidents_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.ComboBox cboIncCustomerName;
        private System.Windows.Forms.Label lblCustomersProducts;
        private System.Windows.Forms.ComboBox cboIncProducts;
        private System.Windows.Forms.Label lblTechnician;
        private System.Windows.Forms.ComboBox cboIncTecnician;
        private System.Windows.Forms.Label lblIssue;
        private System.Windows.Forms.Label lblIncDescription;
        private System.Windows.Forms.TextBox txtIncidentDescription;
        private System.Windows.Forms.DateTimePicker dtpDateTicketOpened;
        private System.Windows.Forms.Label lblDateTicketOpened;
        private System.Windows.Forms.DateTimePicker dtpDateTicketClosed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveIncident;
        private System.Windows.Forms.ComboBox cboIncidentName;
        private System.Windows.Forms.CheckBox chkAddNewIncident;
    }
}