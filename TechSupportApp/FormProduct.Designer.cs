namespace TechSupportApp
{
    partial class FormProduct
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProdCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.dateTimeProd = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboName = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cboProdCode = new System.Windows.Forms.ComboBox();
            this.btnDeleteProd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Version: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Release Date:";
            // 
            // txtProdCode
            // 
            this.txtProdCode.Location = new System.Drawing.Point(128, 32);
            this.txtProdCode.Name = "txtProdCode";
            this.txtProdCode.Size = new System.Drawing.Size(181, 20);
            this.txtProdCode.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(128, 69);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(181, 20);
            this.txtName.TabIndex = 5;
            this.txtName.Visible = false;
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(128, 106);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.ReadOnly = true;
            this.txtVersion.Size = new System.Drawing.Size(181, 20);
            this.txtVersion.TabIndex = 6;
            // 
            // dateTimeProd
            // 
            this.dateTimeProd.Enabled = false;
            this.dateTimeProd.Location = new System.Drawing.Point(128, 143);
            this.dateTimeProd.Name = "dateTimeProd";
            this.dateTimeProd.Size = new System.Drawing.Size(181, 20);
            this.dateTimeProd.TabIndex = 7;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(278, 208);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(85, 40);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(30, 208);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 40);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cboName
            // 
            this.cboName.FormattingEnabled = true;
            this.cboName.Location = new System.Drawing.Point(128, 69);
            this.cboName.Name = "cboName";
            this.cboName.Size = new System.Drawing.Size(181, 21);
            this.cboName.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 41);
            this.button1.TabIndex = 11;
            this.button1.Text = "Create New Product";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboProdCode
            // 
            this.cboProdCode.FormattingEnabled = true;
            this.cboProdCode.Location = new System.Drawing.Point(128, 32);
            this.cboProdCode.Name = "cboProdCode";
            this.cboProdCode.Size = new System.Drawing.Size(181, 21);
            this.cboProdCode.TabIndex = 12;
            // 
            // btnDeleteProd
            // 
            this.btnDeleteProd.Location = new System.Drawing.Point(154, 208);
            this.btnDeleteProd.Name = "btnDeleteProd";
            this.btnDeleteProd.Size = new System.Drawing.Size(85, 40);
            this.btnDeleteProd.TabIndex = 13;
            this.btnDeleteProd.Text = "Delete Product";
            this.btnDeleteProd.UseVisualStyleBackColor = true;
            // 
            // FormProduct
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(421, 288);
            this.Controls.Add(this.btnDeleteProd);
            this.Controls.Add(this.cboProdCode);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dateTimeProd);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtProdCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormProduct";
            this.Text = "FormProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProdCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboProdCode;
        private System.Windows.Forms.DateTimePicker dateTimeProd;
        private System.Windows.Forms.Button btnDeleteProd;
    }
}