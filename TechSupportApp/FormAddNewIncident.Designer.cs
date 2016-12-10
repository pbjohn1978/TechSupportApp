namespace TechSupportApp
{
    partial class FormAddNewIncident
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblCustomerInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboProductListToRegisterIncident = new System.Windows.Forms.ComboBox();
            this.cboSelectTechnicianToRegisterIncident = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddIncidentTitle = new System.Windows.Forms.TextBox();
            this.txtDescribeIncident = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mskAddDateOpened = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mskAddDateResolved = new System.Windows.Forms.MaskedTextBox();
            this.btnAddNewIncidentRecord = new System.Windows.Forms.Button();
            this.cboSelectCustomerAddNewIncident = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCustomerInfo
            // 
            this.lblCustomerInfo.AutoSize = true;
            this.lblCustomerInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCustomerInfo.Location = new System.Drawing.Point(133, 28);
            this.lblCustomerInfo.Name = "lblCustomerInfo";
            this.lblCustomerInfo.Size = new System.Drawing.Size(2, 15);
            this.lblCustomerInfo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Product:";
            // 
            // cboProductListToRegisterIncident
            // 
            this.cboProductListToRegisterIncident.FormattingEnabled = true;
            this.cboProductListToRegisterIncident.Location = new System.Drawing.Point(133, 58);
            this.cboProductListToRegisterIncident.Name = "cboProductListToRegisterIncident";
            this.cboProductListToRegisterIncident.Size = new System.Drawing.Size(158, 21);
            this.cboProductListToRegisterIncident.TabIndex = 4;
            this.cboProductListToRegisterIncident.Text = "Select Product from List";
            this.cboProductListToRegisterIncident.SelectedIndexChanged += new System.EventHandler(this.cboProductListToRegisterIncident_SelectedIndexChanged);
            // 
            // cboSelectTechnicianToRegisterIncident
            // 
            this.cboSelectTechnicianToRegisterIncident.FormattingEnabled = true;
            this.cboSelectTechnicianToRegisterIncident.Location = new System.Drawing.Point(133, 89);
            this.cboSelectTechnicianToRegisterIncident.Name = "cboSelectTechnicianToRegisterIncident";
            this.cboSelectTechnicianToRegisterIncident.Size = new System.Drawing.Size(158, 21);
            this.cboSelectTechnicianToRegisterIncident.TabIndex = 5;
            this.cboSelectTechnicianToRegisterIncident.Text = "Select Technician from List";
            this.cboSelectTechnicianToRegisterIncident.SelectedIndexChanged += new System.EventHandler(this.cboSelectTechnicianToRegisterIncident_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select Technician:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Incident Title:";
            // 
            // txtAddIncidentTitle
            // 
            this.txtAddIncidentTitle.Location = new System.Drawing.Point(133, 123);
            this.txtAddIncidentTitle.Name = "txtAddIncidentTitle";
            this.txtAddIncidentTitle.Size = new System.Drawing.Size(158, 20);
            this.txtAddIncidentTitle.TabIndex = 8;
            // 
            // txtDescribeIncident
            // 
            this.txtDescribeIncident.Location = new System.Drawing.Point(133, 170);
            this.txtDescribeIncident.Multiline = true;
            this.txtDescribeIncident.Name = "txtDescribeIncident";
            this.txtDescribeIncident.Size = new System.Drawing.Size(308, 79);
            this.txtDescribeIncident.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Describe Incident:";
            // 
            // mskAddDateOpened
            // 
            this.mskAddDateOpened.Location = new System.Drawing.Point(323, 58);
            this.mskAddDateOpened.Mask = "00/00/0000";
            this.mskAddDateOpened.Name = "mskAddDateOpened";
            this.mskAddDateOpened.Size = new System.Drawing.Size(118, 20);
            this.mskAddDateOpened.TabIndex = 11;
            this.mskAddDateOpened.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Date Incident Reported:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(323, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "If Resolved, Enter Date:";
            // 
            // mskAddDateResolved
            // 
            this.mskAddDateResolved.Location = new System.Drawing.Point(326, 116);
            this.mskAddDateResolved.Mask = "00/00/0000";
            this.mskAddDateResolved.Name = "mskAddDateResolved";
            this.mskAddDateResolved.Size = new System.Drawing.Size(115, 20);
            this.mskAddDateResolved.TabIndex = 14;
            this.mskAddDateResolved.ValidatingType = typeof(System.DateTime);
            // 
            // btnAddNewIncidentRecord
            // 
            this.btnAddNewIncidentRecord.Location = new System.Drawing.Point(233, 275);
            this.btnAddNewIncidentRecord.Name = "btnAddNewIncidentRecord";
            this.btnAddNewIncidentRecord.Size = new System.Drawing.Size(91, 40);
            this.btnAddNewIncidentRecord.TabIndex = 15;
            this.btnAddNewIncidentRecord.Text = "Add New Incident";
            this.btnAddNewIncidentRecord.UseVisualStyleBackColor = true;
            this.btnAddNewIncidentRecord.Click += new System.EventHandler(this.btnAddNewIncidentRecord_Click);
            // 
            // cboSelectCustomerAddNewIncident
            // 
            this.cboSelectCustomerAddNewIncident.FormattingEnabled = true;
            this.cboSelectCustomerAddNewIncident.Location = new System.Drawing.Point(133, 27);
            this.cboSelectCustomerAddNewIncident.Name = "cboSelectCustomerAddNewIncident";
            this.cboSelectCustomerAddNewIncident.Size = new System.Drawing.Size(158, 21);
            this.cboSelectCustomerAddNewIncident.TabIndex = 16;
            this.cboSelectCustomerAddNewIncident.Text = "Select a Customer";
            this.cboSelectCustomerAddNewIncident.SelectedIndexChanged += new System.EventHandler(this.cboSelectCustomerAddNewIncident_SelectedIndexChanged);
            // 
            // FormAddNewIncident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 343);
            this.Controls.Add(this.cboSelectCustomerAddNewIncident);
            this.Controls.Add(this.btnAddNewIncidentRecord);
            this.Controls.Add(this.mskAddDateResolved);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mskAddDateOpened);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescribeIncident);
            this.Controls.Add(this.txtAddIncidentTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboSelectTechnicianToRegisterIncident);
            this.Controls.Add(this.cboProductListToRegisterIncident);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCustomerInfo);
            this.Controls.Add(this.label1);
            this.Name = "FormAddNewIncident";
            this.Text = "FormAddNewIncident";
            this.Load += new System.EventHandler(this.FormAddNewIncident_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCustomerInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboProductListToRegisterIncident;
        private System.Windows.Forms.ComboBox cboSelectTechnicianToRegisterIncident;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddIncidentTitle;
        private System.Windows.Forms.TextBox txtDescribeIncident;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskAddDateOpened;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mskAddDateResolved;
        private System.Windows.Forms.Button btnAddNewIncidentRecord;
        private System.Windows.Forms.ComboBox cboSelectCustomerAddNewIncident;
    }
}