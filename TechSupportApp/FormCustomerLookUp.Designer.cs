namespace TechSupportApp
{
    partial class FormCustomerLookUp
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
            this.CustomerDropDownList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLabCustID = new System.Windows.Forms.Label();
            this.txtLabCustName = new System.Windows.Forms.Label();
            this.txtLabCustAddress = new System.Windows.Forms.Label();
            this.txtLabCustCity = new System.Windows.Forms.Label();
            this.txtLabCustState = new System.Windows.Forms.Label();
            this.txtLabCustZip = new System.Windows.Forms.Label();
            this.txtLabCustPhone = new System.Windows.Forms.Label();
            this.txtLabCustEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CustomerDropDownList
            // 
            this.CustomerDropDownList.FormattingEnabled = true;
            this.CustomerDropDownList.Location = new System.Drawing.Point(30, 33);
            this.CustomerDropDownList.Name = "CustomerDropDownList";
            this.CustomerDropDownList.Size = new System.Drawing.Size(326, 21);
            this.CustomerDropDownList.TabIndex = 0;
            this.CustomerDropDownList.Text = "Select Customer From List:";
            this.CustomerDropDownList.SelectedIndexChanged += new System.EventHandler(this.CustomerDropDownList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Customer Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Customer City:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Customer State:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Customer Zip Code:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Customer Phone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(76, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Customer Email:";
            // 
            // txtLabCustID
            // 
            this.txtLabCustID.AutoSize = true;
            this.txtLabCustID.Location = new System.Drawing.Point(164, 89);
            this.txtLabCustID.Name = "txtLabCustID";
            this.txtLabCustID.Size = new System.Drawing.Size(31, 13);
            this.txtLabCustID.TabIndex = 16;
            this.txtLabCustID.Text = "        ";
            // 
            // txtLabCustName
            // 
            this.txtLabCustName.AutoSize = true;
            this.txtLabCustName.Location = new System.Drawing.Point(164, 115);
            this.txtLabCustName.Name = "txtLabCustName";
            this.txtLabCustName.Size = new System.Drawing.Size(31, 13);
            this.txtLabCustName.TabIndex = 15;
            this.txtLabCustName.Text = "        ";
            // 
            // txtLabCustAddress
            // 
            this.txtLabCustAddress.AutoSize = true;
            this.txtLabCustAddress.Location = new System.Drawing.Point(164, 141);
            this.txtLabCustAddress.Name = "txtLabCustAddress";
            this.txtLabCustAddress.Size = new System.Drawing.Size(31, 13);
            this.txtLabCustAddress.TabIndex = 14;
            this.txtLabCustAddress.Text = "        ";
            // 
            // txtLabCustCity
            // 
            this.txtLabCustCity.AutoSize = true;
            this.txtLabCustCity.Location = new System.Drawing.Point(164, 168);
            this.txtLabCustCity.Name = "txtLabCustCity";
            this.txtLabCustCity.Size = new System.Drawing.Size(31, 13);
            this.txtLabCustCity.TabIndex = 13;
            this.txtLabCustCity.Text = "        ";
            // 
            // txtLabCustState
            // 
            this.txtLabCustState.AutoSize = true;
            this.txtLabCustState.Location = new System.Drawing.Point(164, 194);
            this.txtLabCustState.Name = "txtLabCustState";
            this.txtLabCustState.Size = new System.Drawing.Size(31, 13);
            this.txtLabCustState.TabIndex = 12;
            this.txtLabCustState.Text = "        ";
            // 
            // txtLabCustZip
            // 
            this.txtLabCustZip.AutoSize = true;
            this.txtLabCustZip.Location = new System.Drawing.Point(164, 220);
            this.txtLabCustZip.Name = "txtLabCustZip";
            this.txtLabCustZip.Size = new System.Drawing.Size(31, 13);
            this.txtLabCustZip.TabIndex = 11;
            this.txtLabCustZip.Text = "        ";
            // 
            // txtLabCustPhone
            // 
            this.txtLabCustPhone.AutoSize = true;
            this.txtLabCustPhone.Location = new System.Drawing.Point(164, 245);
            this.txtLabCustPhone.Name = "txtLabCustPhone";
            this.txtLabCustPhone.Size = new System.Drawing.Size(31, 13);
            this.txtLabCustPhone.TabIndex = 10;
            this.txtLabCustPhone.Text = "        ";
            // 
            // txtLabCustEmail
            // 
            this.txtLabCustEmail.AutoSize = true;
            this.txtLabCustEmail.Location = new System.Drawing.Point(164, 271);
            this.txtLabCustEmail.Name = "txtLabCustEmail";
            this.txtLabCustEmail.Size = new System.Drawing.Size(31, 13);
            this.txtLabCustEmail.TabIndex = 9;
            this.txtLabCustEmail.Text = "        ";
            // 
            // FormCustomerLookUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 341);
            this.Controls.Add(this.txtLabCustID);
            this.Controls.Add(this.txtLabCustName);
            this.Controls.Add(this.txtLabCustAddress);
            this.Controls.Add(this.txtLabCustCity);
            this.Controls.Add(this.txtLabCustState);
            this.Controls.Add(this.txtLabCustZip);
            this.Controls.Add(this.txtLabCustPhone);
            this.Controls.Add(this.txtLabCustEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerDropDownList);
            this.Name = "FormCustomerLookUp";
            this.Text = "FormCustomerLookUp";
            this.Load += new System.EventHandler(this.FormCustomerLookUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CustomerDropDownList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txtLabCustID;
        private System.Windows.Forms.Label txtLabCustName;
        private System.Windows.Forms.Label txtLabCustAddress;
        private System.Windows.Forms.Label txtLabCustCity;
        private System.Windows.Forms.Label txtLabCustState;
        private System.Windows.Forms.Label txtLabCustZip;
        private System.Windows.Forms.Label txtLabCustPhone;
        private System.Windows.Forms.Label txtLabCustEmail;
    }
}