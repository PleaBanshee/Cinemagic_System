namespace RandomProj
{
    partial class Main
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
            this.btnCommitSale = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCommitSale
            // 
            this.btnCommitSale.Location = new System.Drawing.Point(314, 313);
            this.btnCommitSale.Margin = new System.Windows.Forms.Padding(2);
            this.btnCommitSale.Name = "btnCommitSale";
            this.btnCommitSale.Size = new System.Drawing.Size(114, 50);
            this.btnCommitSale.TabIndex = 0;
            this.btnCommitSale.Text = "PERFORM A SNACK SALE";
            this.btnCommitSale.UseVisualStyleBackColor = true;
            this.btnCommitSale.Click += new System.EventHandler(this.btnCommitSale_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(207, 313);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(102, 53);
            this.btnCustomers.TabIndex = 1;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(433, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "Booking";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 409);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnCommitSale);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCommitSale;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button button1;
    }
}