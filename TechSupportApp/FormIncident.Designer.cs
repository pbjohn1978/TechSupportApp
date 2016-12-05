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
            this.label1 = new System.Windows.Forms.Label();
            this.lstProductsRegisteredToCustomer = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstIncidentsRegisteredToProduct = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnViewIncidentsRegisteredToProduct = new System.Windows.Forms.Button();
            this.btnAddNewIncident = new System.Windows.Forms.Button();
            this.btnUpdateSelectedIncident = new System.Windows.Forms.Button();
            this.btnDeleteSelectedIncident = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboCustomerListforIncidents
            // 
            this.cboCustomerListforIncidents.FormattingEnabled = true;
            this.cboCustomerListforIncidents.Location = new System.Drawing.Point(57, 53);
            this.cboCustomerListforIncidents.Name = "cboCustomerListforIncidents";
            this.cboCustomerListforIncidents.Size = new System.Drawing.Size(187, 21);
            this.cboCustomerListforIncidents.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer:";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "View Products Registered to Customer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnViewIncidentsRegisteredToProduct
            // 
            this.btnViewIncidentsRegisteredToProduct.Location = new System.Drawing.Point(316, 107);
            this.btnViewIncidentsRegisteredToProduct.Name = "btnViewIncidentsRegisteredToProduct";
            this.btnViewIncidentsRegisteredToProduct.Size = new System.Drawing.Size(159, 47);
            this.btnViewIncidentsRegisteredToProduct.TabIndex = 7;
            this.btnViewIncidentsRegisteredToProduct.Text = "View Incidents Registed to Product";
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
            // FormIncident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 342);
            this.Controls.Add(this.btnDeleteSelectedIncident);
            this.Controls.Add(this.btnUpdateSelectedIncident);
            this.Controls.Add(this.btnAddNewIncident);
            this.Controls.Add(this.btnViewIncidentsRegisteredToProduct);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstIncidentsRegisteredToProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstProductsRegisteredToCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCustomerListforIncidents);
            this.Name = "FormIncident";
            this.Text = "Incident";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCustomerListforIncidents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstProductsRegisteredToCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstIncidentsRegisteredToProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnViewIncidentsRegisteredToProduct;
        private System.Windows.Forms.Button btnAddNewIncident;
        private System.Windows.Forms.Button btnUpdateSelectedIncident;
        private System.Windows.Forms.Button btnDeleteSelectedIncident;
    }
}