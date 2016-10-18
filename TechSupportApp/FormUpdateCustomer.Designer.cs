namespace TechSupportApp
{
    partial class FormUpdateCustomer
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
            this.cboCustomerDropDownList = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.txtCustomerCity = new System.Windows.Forms.TextBox();
            this.txtCustomerState = new System.Windows.Forms.TextBox();
            this.txtCustomerZip = new System.Windows.Forms.TextBox();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLabCustomerID = new System.Windows.Forms.Label();
            this.txtLabCustomerName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboCustomerDropDownList
            // 
            this.cboCustomerDropDownList.FormattingEnabled = true;
            this.cboCustomerDropDownList.Location = new System.Drawing.Point(40, 36);
            this.cboCustomerDropDownList.Name = "cboCustomerDropDownList";
            this.cboCustomerDropDownList.Size = new System.Drawing.Size(308, 21);
            this.cboCustomerDropDownList.TabIndex = 0;
            this.cboCustomerDropDownList.Text = "Please Select a Customer To Update:";
            this.cboCustomerDropDownList.SelectedIndexChanged += new System.EventHandler(this.cboCustomerDropDownList_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Customer Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Customer Phone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Customer Zip Code:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Customer State:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Customer City:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Customer Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Customer Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Customer ID:";
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Location = new System.Drawing.Point(143, 129);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(887, 20);
            this.txtCustomerAddress.TabIndex = 27;
            // 
            // txtCustomerCity
            // 
            this.txtCustomerCity.Location = new System.Drawing.Point(143, 155);
            this.txtCustomerCity.Name = "txtCustomerCity";
            this.txtCustomerCity.Size = new System.Drawing.Size(887, 20);
            this.txtCustomerCity.TabIndex = 28;
            // 
            // txtCustomerState
            // 
            this.txtCustomerState.Location = new System.Drawing.Point(143, 181);
            this.txtCustomerState.Name = "txtCustomerState";
            this.txtCustomerState.Size = new System.Drawing.Size(887, 20);
            this.txtCustomerState.TabIndex = 29;
            // 
            // txtCustomerZip
            // 
            this.txtCustomerZip.Location = new System.Drawing.Point(143, 207);
            this.txtCustomerZip.Name = "txtCustomerZip";
            this.txtCustomerZip.Size = new System.Drawing.Size(887, 20);
            this.txtCustomerZip.TabIndex = 30;
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Location = new System.Drawing.Point(143, 233);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(887, 20);
            this.txtCustomerPhone.TabIndex = 31;
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Location = new System.Drawing.Point(143, 262);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(887, 20);
            this.txtCustomerEmail.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(844, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 58);
            this.button1.TabIndex = 33;
            this.button1.Text = "Done Updating";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(627, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(211, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = " (Must Be Pressed To Update Database)-->";
            // 
            // txtLabCustomerID
            // 
            this.txtLabCustomerID.AutoSize = true;
            this.txtLabCustomerID.Location = new System.Drawing.Point(144, 80);
            this.txtLabCustomerID.Name = "txtLabCustomerID";
            this.txtLabCustomerID.Size = new System.Drawing.Size(19, 13);
            this.txtLabCustomerID.TabIndex = 35;
            this.txtLabCustomerID.Text = "    ";
            // 
            // txtLabCustomerName
            // 
            this.txtLabCustomerName.AutoSize = true;
            this.txtLabCustomerName.Location = new System.Drawing.Point(144, 106);
            this.txtLabCustomerName.Name = "txtLabCustomerName";
            this.txtLabCustomerName.Size = new System.Drawing.Size(19, 13);
            this.txtLabCustomerName.TabIndex = 36;
            this.txtLabCustomerName.Text = "    ";
            // 
            // FormUpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 377);
            this.Controls.Add(this.txtLabCustomerName);
            this.Controls.Add(this.txtLabCustomerID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCustomerEmail);
            this.Controls.Add(this.txtCustomerPhone);
            this.Controls.Add(this.txtCustomerZip);
            this.Controls.Add(this.txtCustomerState);
            this.Controls.Add(this.txtCustomerCity);
            this.Controls.Add(this.txtCustomerAddress);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCustomerDropDownList);
            this.Name = "FormUpdateCustomer";
            this.Text = "UpdateCustomer";
            this.Load += new System.EventHandler(this.FormUpdateCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCustomerDropDownList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.TextBox txtCustomerCity;
        private System.Windows.Forms.TextBox txtCustomerState;
        private System.Windows.Forms.TextBox txtCustomerZip;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txtLabCustomerID;
        private System.Windows.Forms.Label txtLabCustomerName;
    }
}