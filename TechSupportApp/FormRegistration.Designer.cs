namespace TechSupportApp
{
    partial class FormRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistration));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeRegDate = new System.Windows.Forms.DateTimePicker();
            this.cboCustomers = new System.Windows.Forms.ComboBox();
            this.cboProducts = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnViewRegsForCust = new System.Windows.Forms.Button();
            this.btnViewRegsForProd = new System.Windows.Forms.Button();
            this.listBoxDisplay = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Registration Date:";
            // 
            // dateTimeRegDate
            // 
            this.dateTimeRegDate.Location = new System.Drawing.Point(162, 123);
            this.dateTimeRegDate.Name = "dateTimeRegDate";
            this.dateTimeRegDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimeRegDate.TabIndex = 3;
            // 
            // cboCustomers
            // 
            this.cboCustomers.FormattingEnabled = true;
            this.cboCustomers.Location = new System.Drawing.Point(123, 25);
            this.cboCustomers.Name = "cboCustomers";
            this.cboCustomers.Size = new System.Drawing.Size(239, 21);
            this.cboCustomers.TabIndex = 4;
            this.cboCustomers.Text = "Select Customer...";
            this.cboCustomers.DropDown += new System.EventHandler(this.cboCustomers_DropDown);
            // 
            // cboProducts
            // 
            this.cboProducts.FormattingEnabled = true;
            this.cboProducts.Location = new System.Drawing.Point(123, 74);
            this.cboProducts.Name = "cboProducts";
            this.cboProducts.Size = new System.Drawing.Size(239, 21);
            this.cboProducts.TabIndex = 5;
            this.cboProducts.Text = "Select Product...";
            this.cboProducts.DropDown += new System.EventHandler(this.cboProducts_DropDown);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(435, 185);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(89, 40);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Add Registration";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(25, 185);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 40);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(230, 185);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 40);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete Registration";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnViewRegsForCust
            // 
            this.btnViewRegsForCust.Location = new System.Drawing.Point(385, 25);
            this.btnViewRegsForCust.Name = "btnViewRegsForCust";
            this.btnViewRegsForCust.Size = new System.Drawing.Size(191, 23);
            this.btnViewRegsForCust.TabIndex = 9;
            this.btnViewRegsForCust.Text = "View Registrations for this Customer";
            this.btnViewRegsForCust.UseVisualStyleBackColor = true;
            this.btnViewRegsForCust.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnViewRegsForProd
            // 
            this.btnViewRegsForProd.Location = new System.Drawing.Point(385, 78);
            this.btnViewRegsForProd.Name = "btnViewRegsForProd";
            this.btnViewRegsForProd.Size = new System.Drawing.Size(191, 23);
            this.btnViewRegsForProd.TabIndex = 10;
            this.btnViewRegsForProd.Text = "View Registrations for this Product";
            this.btnViewRegsForProd.UseVisualStyleBackColor = true;
            this.btnViewRegsForProd.Click += new System.EventHandler(this.btnViewRegsForProd_Click);
            // 
            // listBoxDisplay
            // 
            this.listBoxDisplay.FormattingEnabled = true;
            this.listBoxDisplay.Items.AddRange(new object[] {
            " "});
            this.listBoxDisplay.Location = new System.Drawing.Point(613, 41);
            this.listBoxDisplay.Name = "listBoxDisplay";
            this.listBoxDisplay.ScrollAlwaysVisible = true;
            this.listBoxDisplay.Size = new System.Drawing.Size(279, 186);
            this.listBoxDisplay.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(610, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "CustomerID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(693, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "ProductCode";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(780, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "RegistrationDate";
            // 
            // FormRegistration
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(904, 287);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxDisplay);
            this.Controls.Add(this.btnViewRegsForProd);
            this.Controls.Add(this.btnViewRegsForCust);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cboProducts);
            this.Controls.Add(this.cboCustomers);
            this.Controls.Add(this.dateTimeRegDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRegistration";
            this.Text = "Registrations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeRegDate;
        private System.Windows.Forms.ComboBox cboCustomers;
        private System.Windows.Forms.ComboBox cboProducts;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnViewRegsForCust;
        private System.Windows.Forms.Button btnViewRegsForProd;
        private System.Windows.Forms.ListBox listBoxDisplay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}