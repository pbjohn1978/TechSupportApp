namespace TechSupportApp
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnIncidents = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnRegistrations = new System.Windows.Forms.Button();
            this.btnTechnicians = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(157, 84);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(112, 73);
            this.btnCustomer.TabIndex = 0;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnIncidents
            // 
            this.btnIncidents.Location = new System.Drawing.Point(437, 84);
            this.btnIncidents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIncidents.Name = "btnIncidents";
            this.btnIncidents.Size = new System.Drawing.Size(112, 73);
            this.btnIncidents.TabIndex = 1;
            this.btnIncidents.Text = "Incidents";
            this.btnIncidents.UseVisualStyleBackColor = true;
            this.btnIncidents.Click += new System.EventHandler(this.btnIncidents_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(157, 188);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(112, 73);
            this.btnProducts.TabIndex = 2;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnRegistrations
            // 
            this.btnRegistrations.Location = new System.Drawing.Point(437, 188);
            this.btnRegistrations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistrations.Name = "btnRegistrations";
            this.btnRegistrations.Size = new System.Drawing.Size(112, 73);
            this.btnRegistrations.TabIndex = 3;
            this.btnRegistrations.Text = "Registrations";
            this.btnRegistrations.UseVisualStyleBackColor = true;
            this.btnRegistrations.Click += new System.EventHandler(this.btnRegistrations_Click);
            // 
            // btnTechnicians
            // 
            this.btnTechnicians.Location = new System.Drawing.Point(289, 295);
            this.btnTechnicians.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTechnicians.Name = "btnTechnicians";
            this.btnTechnicians.Size = new System.Drawing.Size(112, 73);
            this.btnTechnicians.TabIndex = 4;
            this.btnTechnicians.Text = "Technicians";
            this.btnTechnicians.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 436);
            this.Controls.Add(this.btnTechnicians);
            this.Controls.Add(this.btnRegistrations);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnIncidents);
            this.Controls.Add(this.btnCustomer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = "Tech Support App";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnIncidents;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnRegistrations;
        private System.Windows.Forms.Button btnTechnicians;
    }
}

