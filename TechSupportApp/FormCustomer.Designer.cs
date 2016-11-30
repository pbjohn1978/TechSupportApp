namespace TechSupportApp
{
    partial class FormCustomer
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
            this.cboCustomerList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLabCustomerID = new System.Windows.Forms.Label();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.txtCustomerCity = new System.Windows.Forms.TextBox();
            this.txtCustomerState = new System.Windows.Forms.TextBox();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.btnCustomerAddNew = new System.Windows.Forms.Button();
            this.btnCustomerDelete = new System.Windows.Forms.Button();
            this.txtCustomerPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtCustomerZip = new System.Windows.Forms.MaskedTextBox();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboCustomerList
            // 
            this.cboCustomerList.FormattingEnabled = true;
            this.cboCustomerList.Location = new System.Drawing.Point(36, 57);
            this.cboCustomerList.Name = "cboCustomerList";
            this.cboCustomerList.Size = new System.Drawing.Size(390, 21);
            this.cboCustomerList.TabIndex = 10;
            this.cboCustomerList.Text = "Select Customer From List:";
            this.cboCustomerList.SelectedIndexChanged += new System.EventHandler(this.cboCustomerList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Look Up:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer Id Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Customer Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "City:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "State (2 char. Postal Code):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Zip Code:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(79, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Phone Number:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(125, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Email:";
            // 
            // txtLabCustomerID
            // 
            this.txtLabCustomerID.AutoSize = true;
            this.txtLabCustomerID.Location = new System.Drawing.Point(166, 103);
            this.txtLabCustomerID.Name = "txtLabCustomerID";
            this.txtLabCustomerID.Size = new System.Drawing.Size(22, 13);
            this.txtLabCustomerID.TabIndex = 0;
            this.txtLabCustomerID.Text = "     ";
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Location = new System.Drawing.Point(166, 152);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(289, 20);
            this.txtCustomerAddress.TabIndex = 2;
            // 
            // txtCustomerCity
            // 
            this.txtCustomerCity.Location = new System.Drawing.Point(166, 178);
            this.txtCustomerCity.Name = "txtCustomerCity";
            this.txtCustomerCity.Size = new System.Drawing.Size(289, 20);
            this.txtCustomerCity.TabIndex = 3;
            // 
            // txtCustomerState
            // 
            this.txtCustomerState.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCustomerState.Location = new System.Drawing.Point(166, 204);
            this.txtCustomerState.Name = "txtCustomerState";
            this.txtCustomerState.Size = new System.Drawing.Size(289, 20);
            this.txtCustomerState.TabIndex = 4;
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Location = new System.Drawing.Point(166, 282);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(289, 20);
            this.txtCustomerEmail.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(22, 340);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(123, 42);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update Customer";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(166, 126);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(289, 20);
            this.txtCustomerName.TabIndex = 1;
            // 
            // btnCustomerAddNew
            // 
            this.btnCustomerAddNew.Location = new System.Drawing.Point(166, 340);
            this.btnCustomerAddNew.Name = "btnCustomerAddNew";
            this.btnCustomerAddNew.Size = new System.Drawing.Size(123, 42);
            this.btnCustomerAddNew.TabIndex = 8;
            this.btnCustomerAddNew.Text = "Add New Customer";
            this.btnCustomerAddNew.UseVisualStyleBackColor = true;
            this.btnCustomerAddNew.Click += new System.EventHandler(this.btnCustomerAddNew_Click);
            // 
            // btnCustomerDelete
            // 
            this.btnCustomerDelete.Location = new System.Drawing.Point(664, 23);
            this.btnCustomerDelete.Name = "btnCustomerDelete";
            this.btnCustomerDelete.Size = new System.Drawing.Size(123, 42);
            this.btnCustomerDelete.TabIndex = 0;
            this.btnCustomerDelete.Text = "Delete Customer";
            this.btnCustomerDelete.UseVisualStyleBackColor = true;
            this.btnCustomerDelete.Click += new System.EventHandler(this.btnCustomerDelete_Click);
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Location = new System.Drawing.Point(166, 256);
            this.txtCustomerPhone.Mask = "(999) 000-0000";
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(289, 20);
            this.txtCustomerPhone.TabIndex = 6;
            // 
            // txtCustomerZip
            // 
            this.txtCustomerZip.Location = new System.Drawing.Point(166, 230);
            this.txtCustomerZip.Mask = "00000";
            this.txtCustomerZip.Name = "txtCustomerZip";
            this.txtCustomerZip.Size = new System.Drawing.Size(289, 20);
            this.txtCustomerZip.TabIndex = 5;
            this.txtCustomerZip.ValidatingType = typeof(int);
            // 
            // btnClearForm
            // 
            this.btnClearForm.Location = new System.Drawing.Point(478, 192);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(123, 42);
            this.btnClearForm.TabIndex = 11;
            this.btnClearForm.Text = "Clear Form";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 454);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.txtCustomerZip);
            this.Controls.Add(this.txtCustomerPhone);
            this.Controls.Add(this.btnCustomerDelete);
            this.Controls.Add(this.btnCustomerAddNew);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtCustomerEmail);
            this.Controls.Add(this.txtCustomerState);
            this.Controls.Add(this.txtCustomerCity);
            this.Controls.Add(this.txtCustomerAddress);
            this.Controls.Add(this.txtLabCustomerID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCustomerList);
            this.Name = "FormCustomer";
            this.Text = "0";
            this.Load += new System.EventHandler(this.FormCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCustomerList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txtLabCustomerID;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.TextBox txtCustomerCity;
        private System.Windows.Forms.TextBox txtCustomerState;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Button btnCustomerAddNew;
        private System.Windows.Forms.Button btnCustomerDelete;
        private System.Windows.Forms.MaskedTextBox txtCustomerPhone;
        private System.Windows.Forms.MaskedTextBox txtCustomerZip;
        private System.Windows.Forms.Button btnClearForm;
    }
}