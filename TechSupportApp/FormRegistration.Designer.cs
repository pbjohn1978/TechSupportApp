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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Registration Date:";
            // 
            // dateTimeRegDate
            // 
            this.dateTimeRegDate.Location = new System.Drawing.Point(216, 151);
            this.dateTimeRegDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimeRegDate.Name = "dateTimeRegDate";
            this.dateTimeRegDate.Size = new System.Drawing.Size(265, 22);
            this.dateTimeRegDate.TabIndex = 3;
            // 
            // cboCustomers
            // 
            this.cboCustomers.FormattingEnabled = true;
            this.cboCustomers.Location = new System.Drawing.Point(164, 31);
            this.cboCustomers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboCustomers.Name = "cboCustomers";
            this.cboCustomers.Size = new System.Drawing.Size(317, 24);
            this.cboCustomers.TabIndex = 4;
            this.cboCustomers.Text = "Select Customer...";
            this.cboCustomers.DropDown += new System.EventHandler(this.cboCustomers_DropDown);
            // 
            // cboProducts
            // 
            this.cboProducts.FormattingEnabled = true;
            this.cboProducts.Location = new System.Drawing.Point(164, 91);
            this.cboProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboProducts.Name = "cboProducts";
            this.cboProducts.Size = new System.Drawing.Size(317, 24);
            this.cboProducts.TabIndex = 5;
            this.cboProducts.Text = "Select Product...";
            this.cboProducts.DropDown += new System.EventHandler(this.cboProducts_DropDown);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(580, 228);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(119, 49);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Add Registration";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(33, 228);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 49);
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
            this.btnDelete.Location = new System.Drawing.Point(307, 228);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 49);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete Registration";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(513, 31);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "View Registrations for this Customer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(513, 96);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(255, 28);
            this.button2.TabIndex = 10;
            this.button2.Text = "View Registrations for this Product";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormRegistration
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(809, 353);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cboProducts);
            this.Controls.Add(this.cboCustomers);
            this.Controls.Add(this.dateTimeRegDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormRegistration";
            this.Text = "FormRegistration";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}