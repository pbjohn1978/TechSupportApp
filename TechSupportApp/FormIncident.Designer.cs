namespace TechSupportApp
{
    partial class FormIncident
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
            this.cboCustomerListforIncidents = new System.Windows.Forms.ComboBox();
            this.lblCustomerIDLabel = new System.Windows.Forms.Label();
            this.lstProductsRegisteredToCustomer = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstIncidentsRegisteredToProduct = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnViewProductsRegisteredtoCustomer = new System.Windows.Forms.Button();
            this.btnViewIncidentsRegisteredToProduct = new System.Windows.Forms.Button();
            this.btnAddNewIncident = new System.Windows.Forms.Button();
            this.btnUpdateSelectedIncident = new System.Windows.Forms.Button();
            this.btnDeleteSelectedIncident = new System.Windows.Forms.Button();
            this.lblCustomerNameLabel = new System.Windows.Forms.Label();
            this.lblIncidentCustomerID = new System.Windows.Forms.Label();
            this.lblIncidentCustomerName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboCustomerListforIncidents
            // 
            this.cboCustomerListforIncidents.FormattingEnabled = true;
            this.cboCustomerListforIncidents.Location = new System.Drawing.Point(250, 12);
            this.cboCustomerListforIncidents.Name = "cboCustomerListforIncidents";
            this.cboCustomerListforIncidents.Size = new System.Drawing.Size(187, 21);
            this.cboCustomerListforIncidents.TabIndex = 0;
            this.cboCustomerListforIncidents.Text = "Select Customer from List";
            this.cboCustomerListforIncidents.SelectedIndexChanged += new System.EventHandler(this.cboCustomerListforIncidents_SelectedIndexChanged);
            // 
            // lblCustomerIDLabel
            // 
            this.lblCustomerIDLabel.AutoSize = true;
            this.lblCustomerIDLabel.Location = new System.Drawing.Point(54, 53);
            this.lblCustomerIDLabel.Name = "lblCustomerIDLabel";
            this.lblCustomerIDLabel.Size = new System.Drawing.Size(0, 13);
            this.lblCustomerIDLabel.TabIndex = 1;
            // 
            // lstProductsRegisteredToCustomer
            // 
            this.lstProductsRegisteredToCustomer.FormattingEnabled = true;
            this.lstProductsRegisteredToCustomer.Location = new System.Drawing.Point(57, 172);
            this.lstProductsRegisteredToCustomer.Name = "lstProductsRegisteredToCustomer";
            this.lstProductsRegisteredToCustomer.Size = new System.Drawing.Size(162, 134);
            this.lstProductsRegisteredToCustomer.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // lstIncidentsRegisteredToProduct
            // 
            this.lstIncidentsRegisteredToProduct.FormattingEnabled = true;
            this.lstIncidentsRegisteredToProduct.Location = new System.Drawing.Point(316, 172);
            this.lstIncidentsRegisteredToProduct.Name = "lstIncidentsRegisteredToProduct";
            this.lstIncidentsRegisteredToProduct.Size = new System.Drawing.Size(159, 134);
            this.lstIncidentsRegisteredToProduct.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 5;
            // 
            // btnViewProductsRegisteredtoCustomer
            // 
            this.btnViewProductsRegisteredtoCustomer.Location = new System.Drawing.Point(57, 107);
            this.btnViewProductsRegisteredtoCustomer.Name = "btnViewProductsRegisteredtoCustomer";
            this.btnViewProductsRegisteredtoCustomer.Size = new System.Drawing.Size(162, 47);
            this.btnViewProductsRegisteredtoCustomer.TabIndex = 6;
            this.btnViewProductsRegisteredtoCustomer.Text = "View Products Registered to Customer";
            this.btnViewProductsRegisteredtoCustomer.UseVisualStyleBackColor = true;
            this.btnViewProductsRegisteredtoCustomer.Click += new System.EventHandler(this.btnViewRegisteredProductsIncidentForm);
            // 
            // btnViewIncidentsRegisteredToProduct
            // 
            this.btnViewIncidentsRegisteredToProduct.Location = new System.Drawing.Point(316, 107);
            this.btnViewIncidentsRegisteredToProduct.Name = "btnViewIncidentsRegisteredToProduct";
            this.btnViewIncidentsRegisteredToProduct.Size = new System.Drawing.Size(159, 47);
            this.btnViewIncidentsRegisteredToProduct.TabIndex = 7;
            this.btnViewIncidentsRegisteredToProduct.Text = "View Incidents for Product";
            this.btnViewIncidentsRegisteredToProduct.UseVisualStyleBackColor = true;
            // 
            // btnAddNewIncident
            // 
            this.btnAddNewIncident.Location = new System.Drawing.Point(534, 111);
            this.btnAddNewIncident.Name = "btnAddNewIncident";
            this.btnAddNewIncident.Size = new System.Drawing.Size(120, 43);
            this.btnAddNewIncident.TabIndex = 8;
            this.btnAddNewIncident.Text = "Add New Incident";
            this.btnAddNewIncident.UseVisualStyleBackColor = true;
            this.btnAddNewIncident.Click += new System.EventHandler(this.btnAddNewIncident_Click);
            // 
            // btnUpdateSelectedIncident
            // 
            this.btnUpdateSelectedIncident.Location = new System.Drawing.Point(534, 188);
            this.btnUpdateSelectedIncident.Name = "btnUpdateSelectedIncident";
            this.btnUpdateSelectedIncident.Size = new System.Drawing.Size(120, 43);
            this.btnUpdateSelectedIncident.TabIndex = 9;
            this.btnUpdateSelectedIncident.Text = "Update Selected Incident";
            this.btnUpdateSelectedIncident.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSelectedIncident
            // 
            this.btnDeleteSelectedIncident.Location = new System.Drawing.Point(534, 263);
            this.btnDeleteSelectedIncident.Name = "btnDeleteSelectedIncident";
            this.btnDeleteSelectedIncident.Size = new System.Drawing.Size(120, 43);
            this.btnDeleteSelectedIncident.TabIndex = 10;
            this.btnDeleteSelectedIncident.Text = "Delete Selected Incident";
            this.btnDeleteSelectedIncident.UseVisualStyleBackColor = true;
            // 
            // lblCustomerNameLabel
            // 
            this.lblCustomerNameLabel.AutoSize = true;
            this.lblCustomerNameLabel.Location = new System.Drawing.Point(54, 73);
            this.lblCustomerNameLabel.Name = "lblCustomerNameLabel";
            this.lblCustomerNameLabel.Size = new System.Drawing.Size(0, 13);
            this.lblCustomerNameLabel.TabIndex = 11;
            // 
            // lblIncidentCustomerID
            // 
            this.lblIncidentCustomerID.AutoSize = true;
            this.lblIncidentCustomerID.Location = new System.Drawing.Point(148, 52);
            this.lblIncidentCustomerID.Name = "lblIncidentCustomerID";
            this.lblIncidentCustomerID.Size = new System.Drawing.Size(0, 13);
            this.lblIncidentCustomerID.TabIndex = 12;
            // 
            // lblIncidentCustomerName
            // 
            this.lblIncidentCustomerName.AutoSize = true;
            this.lblIncidentCustomerName.Location = new System.Drawing.Point(148, 72);
            this.lblIncidentCustomerName.Name = "lblIncidentCustomerName";
            this.lblIncidentCustomerName.Size = new System.Drawing.Size(0, 13);
            this.lblIncidentCustomerName.TabIndex = 13;
            // 
            // FormIncident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 342);
            this.Controls.Add(this.lblIncidentCustomerName);
            this.Controls.Add(this.lblIncidentCustomerID);
            this.Controls.Add(this.lblCustomerNameLabel);
            this.Controls.Add(this.btnDeleteSelectedIncident);
            this.Controls.Add(this.btnUpdateSelectedIncident);
            this.Controls.Add(this.btnAddNewIncident);
            this.Controls.Add(this.btnViewIncidentsRegisteredToProduct);
            this.Controls.Add(this.btnViewProductsRegisteredtoCustomer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstIncidentsRegisteredToProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstProductsRegisteredToCustomer);
            this.Controls.Add(this.lblCustomerIDLabel);
            this.Controls.Add(this.cboCustomerListforIncidents);
            this.Name = "FormIncident";
            this.Text = "Incident";
            this.Load += new System.EventHandler(this.FormIncident_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCustomerListforIncidents;
        private System.Windows.Forms.Label lblCustomerIDLabel;
        private System.Windows.Forms.ListBox lstProductsRegisteredToCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstIncidentsRegisteredToProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnViewProductsRegisteredtoCustomer;
        private System.Windows.Forms.Button btnViewIncidentsRegisteredToProduct;
        private System.Windows.Forms.Button btnAddNewIncident;
        private System.Windows.Forms.Button btnUpdateSelectedIncident;
        private System.Windows.Forms.Button btnDeleteSelectedIncident;
        private System.Windows.Forms.Label lblCustomerNameLabel;
        private System.Windows.Forms.Label lblIncidentCustomerID;
        private System.Windows.Forms.Label lblIncidentCustomerName;
    }
}