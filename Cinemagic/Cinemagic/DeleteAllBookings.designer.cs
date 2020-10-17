namespace RandomProj
{
    partial class DeleteAllBookings
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
            this.groupDeleteAllBookings = new System.Windows.Forms.GroupBox();
            this.btnBack_To_Bookings = new System.Windows.Forms.Button();
            this.btnDelete_AllBookings = new System.Windows.Forms.Button();
            this.lblDelAllBookings = new System.Windows.Forms.Label();
            this.spinDeleteAll_Bookings = new System.Windows.Forms.NumericUpDown();
            this.lblDeleteAllBookings = new System.Windows.Forms.Label();
            this.groupDeleteAllBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinDeleteAll_Bookings)).BeginInit();
            this.SuspendLayout();
            // 
            // groupDeleteAllBookings
            // 
            this.groupDeleteAllBookings.Controls.Add(this.btnBack_To_Bookings);
            this.groupDeleteAllBookings.Controls.Add(this.btnDelete_AllBookings);
            this.groupDeleteAllBookings.Controls.Add(this.lblDelAllBookings);
            this.groupDeleteAllBookings.Controls.Add(this.spinDeleteAll_Bookings);
            this.groupDeleteAllBookings.Controls.Add(this.lblDeleteAllBookings);
            this.groupDeleteAllBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDeleteAllBookings.Location = new System.Drawing.Point(-3, 3);
            this.groupDeleteAllBookings.Name = "groupDeleteAllBookings";
            this.groupDeleteAllBookings.Size = new System.Drawing.Size(572, 323);
            this.groupDeleteAllBookings.TabIndex = 24;
            this.groupDeleteAllBookings.TabStop = false;
            this.groupDeleteAllBookings.Text = "DELETE ALL MOVIES";
            // 
            // btnBack_To_Bookings
            // 
            this.btnBack_To_Bookings.Location = new System.Drawing.Point(15, 277);
            this.btnBack_To_Bookings.Name = "btnBack_To_Bookings";
            this.btnBack_To_Bookings.Size = new System.Drawing.Size(85, 36);
            this.btnBack_To_Bookings.TabIndex = 25;
            this.btnBack_To_Bookings.Text = "BACK";
            this.btnBack_To_Bookings.UseVisualStyleBackColor = true;
            this.btnBack_To_Bookings.Click += new System.EventHandler(this.btnBack_To_Bookings_Click);
            // 
            // btnDelete_AllBookings
            // 
            this.btnDelete_AllBookings.Location = new System.Drawing.Point(201, 174);
            this.btnDelete_AllBookings.Name = "btnDelete_AllBookings";
            this.btnDelete_AllBookings.Size = new System.Drawing.Size(102, 23);
            this.btnDelete_AllBookings.TabIndex = 23;
            this.btnDelete_AllBookings.Text = "DELETE";
            this.btnDelete_AllBookings.UseVisualStyleBackColor = true;
            this.btnDelete_AllBookings.Click += new System.EventHandler(this.btnDelete_AllBookings_Click);
            // 
            // lblDelAllBookings
            // 
            this.lblDelAllBookings.AutoSize = true;
            this.lblDelAllBookings.Location = new System.Drawing.Point(102, 74);
            this.lblDelAllBookings.Name = "lblDelAllBookings";
            this.lblDelAllBookings.Size = new System.Drawing.Size(351, 17);
            this.lblDelAllBookings.TabIndex = 22;
            this.lblDelAllBookings.Text = "DELETE ALL BOOKINGS WITH CUSTOMER_ID:";
            // 
            // spinDeleteAll_Bookings
            // 
            this.spinDeleteAll_Bookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinDeleteAll_Bookings.Location = new System.Drawing.Point(201, 103);
            this.spinDeleteAll_Bookings.Name = "spinDeleteAll_Bookings";
            this.spinDeleteAll_Bookings.Size = new System.Drawing.Size(100, 22);
            this.spinDeleteAll_Bookings.TabIndex = 21;
            // 
            // lblDeleteAllBookings
            // 
            this.lblDeleteAllBookings.AutoSize = true;
            this.lblDeleteAllBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteAllBookings.Location = new System.Drawing.Point(102, 105);
            this.lblDeleteAllBookings.Name = "lblDeleteAllBookings";
            this.lblDeleteAllBookings.Size = new System.Drawing.Size(93, 17);
            this.lblDeleteAllBookings.TabIndex = 20;
            this.lblDeleteAllBookings.Text = "Customer_ID:";
            // 
            // DeleteAllBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 328);
            this.Controls.Add(this.groupDeleteAllBookings);
            this.Name = "DeleteAllBookings";
            this.Text = "DeleteAllBookings";
            this.groupDeleteAllBookings.ResumeLayout(false);
            this.groupDeleteAllBookings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinDeleteAll_Bookings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupDeleteAllBookings;
        private System.Windows.Forms.Button btnDelete_AllBookings;
        private System.Windows.Forms.Label lblDelAllBookings;
        private System.Windows.Forms.NumericUpDown spinDeleteAll_Bookings;
        private System.Windows.Forms.Label lblDeleteAllBookings;
        private System.Windows.Forms.Button btnBack_To_Bookings;
    }
}