﻿namespace TechSupportApp
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
            this.components = new System.ComponentModel.Container();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techSupportDataSet = new TechSupportApp.TechSupportDataSet();
            this.customersTableAdapter = new TechSupportApp.TechSupportDataSetTableAdapters.CustomersTableAdapter();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new TechSupportApp.TechSupportDataSetTableAdapters.ProductsTableAdapter();
            this.lstIncidents = new System.Windows.Forms.ListView();
            this.cboAllCustomersIncidentsForm = new System.Windows.Forms.ComboBox();
            this.btnAddNewIncident = new System.Windows.Forms.Button();
            this.btnUpdateIncident = new System.Windows.Forms.Button();
            this.btnDeleteSelectedIncident = new System.Windows.Forms.Button();
            this.chdProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chdProductVersion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chdIncidentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chdTech = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chdIncidentOpenDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chdClosed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblIDLabel = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNameLabel = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techSupportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.techSupportDataSet;
            // 
            // techSupportDataSet
            // 
            this.techSupportDataSet.DataSetName = "TechSupportDataSet";
            this.techSupportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.techSupportDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // lstIncidents
            // 
            this.lstIncidents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chdIncidentID,
            this.chdProductName,
            this.chdProductVersion,
            this.chdTech,
            this.chdIncidentOpenDate,
            this.chdClosed});
            this.lstIncidents.Location = new System.Drawing.Point(41, 83);
            this.lstIncidents.Name = "lstIncidents";
            this.lstIncidents.Size = new System.Drawing.Size(289, 157);
            this.lstIncidents.TabIndex = 0;
            this.lstIncidents.UseCompatibleStateImageBehavior = false;
            // 
            // cboAllCustomersIncidentsForm
            // 
            this.cboAllCustomersIncidentsForm.FormattingEnabled = true;
            this.cboAllCustomersIncidentsForm.Location = new System.Drawing.Point(41, 27);
            this.cboAllCustomersIncidentsForm.Name = "cboAllCustomersIncidentsForm";
            this.cboAllCustomersIncidentsForm.Size = new System.Drawing.Size(186, 21);
            this.cboAllCustomersIncidentsForm.TabIndex = 1;
            this.cboAllCustomersIncidentsForm.Text = "Select Customer from List";
            this.cboAllCustomersIncidentsForm.SelectedIndexChanged += new System.EventHandler(this.cboAllCustomersIncidentsForm_SelectedIndexChanged);
            // 
            // btnAddNewIncident
            // 
            this.btnAddNewIncident.Location = new System.Drawing.Point(377, 83);
            this.btnAddNewIncident.Name = "btnAddNewIncident";
            this.btnAddNewIncident.Size = new System.Drawing.Size(75, 39);
            this.btnAddNewIncident.TabIndex = 2;
            this.btnAddNewIncident.Text = "Add New Incident";
            this.btnAddNewIncident.UseVisualStyleBackColor = true;
            // 
            // btnUpdateIncident
            // 
            this.btnUpdateIncident.Location = new System.Drawing.Point(377, 142);
            this.btnUpdateIncident.Name = "btnUpdateIncident";
            this.btnUpdateIncident.Size = new System.Drawing.Size(75, 39);
            this.btnUpdateIncident.TabIndex = 3;
            this.btnUpdateIncident.Text = "Update Selected Incident";
            this.btnUpdateIncident.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSelectedIncident
            // 
            this.btnDeleteSelectedIncident.Location = new System.Drawing.Point(377, 201);
            this.btnDeleteSelectedIncident.Name = "btnDeleteSelectedIncident";
            this.btnDeleteSelectedIncident.Size = new System.Drawing.Size(75, 39);
            this.btnDeleteSelectedIncident.TabIndex = 4;
            this.btnDeleteSelectedIncident.Text = "Delete Selected Incident";
            this.btnDeleteSelectedIncident.UseVisualStyleBackColor = true;
            // 
            // chdProductName
            // 
            this.chdProductName.DisplayIndex = 0;
            this.chdProductName.Text = "Product Name";
            // 
            // chdProductVersion
            // 
            this.chdProductVersion.DisplayIndex = 1;
            this.chdProductVersion.Text = "Product Version";
            // 
            // chdIncidentID
            // 
            this.chdIncidentID.DisplayIndex = 2;
            this.chdIncidentID.Text = "Incident ID";
            // 
            // chdTech
            // 
            this.chdTech.Text = "Technician Name";
            // 
            // chdIncidentOpenDate
            // 
            this.chdIncidentOpenDate.Text = "Open Date";
            // 
            // chdClosed
            // 
            this.chdClosed.Text = "Closed?";
            // 
            // lblIDLabel
            // 
            this.lblIDLabel.AutoSize = true;
            this.lblIDLabel.Location = new System.Drawing.Point(38, 51);
            this.lblIDLabel.Name = "lblIDLabel";
            this.lblIDLabel.Size = new System.Drawing.Size(0, 13);
            this.lblIDLabel.TabIndex = 5;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(79, 51);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 6;
            // 
            // lblNameLabel
            // 
            this.lblNameLabel.AutoSize = true;
            this.lblNameLabel.Location = new System.Drawing.Point(140, 51);
            this.lblNameLabel.Name = "lblNameLabel";
            this.lblNameLabel.Size = new System.Drawing.Size(0, 13);
            this.lblNameLabel.TabIndex = 7;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(194, 51);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 13);
            this.lblName.TabIndex = 8;
            // 
            // FormIncidents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 284);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNameLabel);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblIDLabel);
            this.Controls.Add(this.btnDeleteSelectedIncident);
            this.Controls.Add(this.btnUpdateIncident);
            this.Controls.Add(this.btnAddNewIncident);
            this.Controls.Add(this.cboAllCustomersIncidentsForm);
            this.Controls.Add(this.lstIncidents);
            this.Name = "FormIncidents";
            this.Text = "FormIncidents";
            this.Load += new System.EventHandler(this.FormIncidents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techSupportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TechSupportDataSet techSupportDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private TechSupportDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private TechSupportDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.ListView lstIncidents;
        private System.Windows.Forms.ColumnHeader chdIncidentID;
        private System.Windows.Forms.ColumnHeader chdProductName;
        private System.Windows.Forms.ColumnHeader chdProductVersion;
        private System.Windows.Forms.ColumnHeader chdTech;
        private System.Windows.Forms.ColumnHeader chdIncidentOpenDate;
        private System.Windows.Forms.ColumnHeader chdClosed;
        private System.Windows.Forms.ComboBox cboAllCustomersIncidentsForm;
        private System.Windows.Forms.Button btnAddNewIncident;
        private System.Windows.Forms.Button btnUpdateIncident;
        private System.Windows.Forms.Button btnDeleteSelectedIncident;
        private System.Windows.Forms.Label lblIDLabel;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNameLabel;
        private System.Windows.Forms.Label lblName;
    }
}