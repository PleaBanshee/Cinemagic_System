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
            this.groupDeleteMovieID = new System.Windows.Forms.GroupBox();
            this.lblDeleteMovies = new System.Windows.Forms.Label();
            this.lblMovie_ID = new System.Windows.Forms.Label();
            this.btnDel_WithMovieID = new System.Windows.Forms.Button();
            this.spinDel_Movies = new System.Windows.Forms.NumericUpDown();
            this.groupDeleteCustomersID = new System.Windows.Forms.GroupBox();
            this.lblDelAllBookings = new System.Windows.Forms.Label();
            this.lblDeleteAllBookings = new System.Windows.Forms.Label();
            this.btnDelete_AllBookings = new System.Windows.Forms.Button();
            this.spinDeleteAll_Bookings = new System.Windows.Forms.NumericUpDown();
            this.btnBack_To_Bookings = new System.Windows.Forms.Button();
            this.groupDeleteAllBookings.SuspendLayout();
            this.groupDeleteMovieID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinDel_Movies)).BeginInit();
            this.groupDeleteCustomersID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinDeleteAll_Bookings)).BeginInit();
            this.SuspendLayout();
            // 
            // groupDeleteAllBookings
            // 
            this.groupDeleteAllBookings.Controls.Add(this.groupDeleteMovieID);
            this.groupDeleteAllBookings.Controls.Add(this.groupDeleteCustomersID);
            this.groupDeleteAllBookings.Controls.Add(this.btnBack_To_Bookings);
            this.groupDeleteAllBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDeleteAllBookings.Location = new System.Drawing.Point(-3, 3);
            this.groupDeleteAllBookings.Name = "groupDeleteAllBookings";
            this.groupDeleteAllBookings.Size = new System.Drawing.Size(1063, 323);
            this.groupDeleteAllBookings.TabIndex = 24;
            this.groupDeleteAllBookings.TabStop = false;
            this.groupDeleteAllBookings.Text = "DELETE ALL BOOKINGS";
            // 
            // groupDeleteMovieID
            // 
            this.groupDeleteMovieID.Controls.Add(this.lblDeleteMovies);
            this.groupDeleteMovieID.Controls.Add(this.lblMovie_ID);
            this.groupDeleteMovieID.Controls.Add(this.btnDel_WithMovieID);
            this.groupDeleteMovieID.Controls.Add(this.spinDel_Movies);
            this.groupDeleteMovieID.Location = new System.Drawing.Point(420, 56);
            this.groupDeleteMovieID.Name = "groupDeleteMovieID";
            this.groupDeleteMovieID.Size = new System.Drawing.Size(374, 186);
            this.groupDeleteMovieID.TabIndex = 27;
            this.groupDeleteMovieID.TabStop = false;
            this.groupDeleteMovieID.Text = "DELETIONS BASED ON MOVIES";
            // 
            // lblDeleteMovies
            // 
            this.lblDeleteMovies.AutoSize = true;
            this.lblDeleteMovies.Location = new System.Drawing.Point(41, 51);
            this.lblDeleteMovies.Name = "lblDeleteMovies";
            this.lblDeleteMovies.Size = new System.Drawing.Size(248, 17);
            this.lblDeleteMovies.TabIndex = 22;
            this.lblDeleteMovies.Text = "ALL BOOKINGS WITH MOVIE_ID:";
            // 
            // lblMovie_ID
            // 
            this.lblMovie_ID.AutoSize = true;
            this.lblMovie_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovie_ID.Location = new System.Drawing.Point(41, 82);
            this.lblMovie_ID.Name = "lblMovie_ID";
            this.lblMovie_ID.Size = new System.Drawing.Size(70, 17);
            this.lblMovie_ID.TabIndex = 20;
            this.lblMovie_ID.Text = "Movie_ID:";
            // 
            // btnDel_WithMovieID
            // 
            this.btnDel_WithMovieID.Location = new System.Drawing.Point(114, 125);
            this.btnDel_WithMovieID.Name = "btnDel_WithMovieID";
            this.btnDel_WithMovieID.Size = new System.Drawing.Size(102, 23);
            this.btnDel_WithMovieID.TabIndex = 23;
            this.btnDel_WithMovieID.Text = "DELETE";
            this.btnDel_WithMovieID.UseVisualStyleBackColor = true;
            this.btnDel_WithMovieID.Click += new System.EventHandler(this.btnDel_WithMovieID_Click);
            // 
            // spinDel_Movies
            // 
            this.spinDel_Movies.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinDel_Movies.Location = new System.Drawing.Point(117, 77);
            this.spinDel_Movies.Name = "spinDel_Movies";
            this.spinDel_Movies.Size = new System.Drawing.Size(100, 22);
            this.spinDel_Movies.TabIndex = 21;
            // 
            // groupDeleteCustomersID
            // 
            this.groupDeleteCustomersID.Controls.Add(this.lblDelAllBookings);
            this.groupDeleteCustomersID.Controls.Add(this.lblDeleteAllBookings);
            this.groupDeleteCustomersID.Controls.Add(this.btnDelete_AllBookings);
            this.groupDeleteCustomersID.Controls.Add(this.spinDeleteAll_Bookings);
            this.groupDeleteCustomersID.Location = new System.Drawing.Point(15, 56);
            this.groupDeleteCustomersID.Name = "groupDeleteCustomersID";
            this.groupDeleteCustomersID.Size = new System.Drawing.Size(374, 186);
            this.groupDeleteCustomersID.TabIndex = 26;
            this.groupDeleteCustomersID.TabStop = false;
            this.groupDeleteCustomersID.Text = "DELETIONS BASED ON CUSTOMERS";
            // 
            // lblDelAllBookings
            // 
            this.lblDelAllBookings.AutoSize = true;
            this.lblDelAllBookings.Location = new System.Drawing.Point(17, 51);
            this.lblDelAllBookings.Name = "lblDelAllBookings";
            this.lblDelAllBookings.Size = new System.Drawing.Size(286, 17);
            this.lblDelAllBookings.TabIndex = 22;
            this.lblDelAllBookings.Text = "ALL BOOKINGS WITH CUSTOMER_ID:";
            // 
            // lblDeleteAllBookings
            // 
            this.lblDeleteAllBookings.AutoSize = true;
            this.lblDeleteAllBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteAllBookings.Location = new System.Drawing.Point(17, 82);
            this.lblDeleteAllBookings.Name = "lblDeleteAllBookings";
            this.lblDeleteAllBookings.Size = new System.Drawing.Size(93, 17);
            this.lblDeleteAllBookings.TabIndex = 20;
            this.lblDeleteAllBookings.Text = "Customer_ID:";
            // 
            // btnDelete_AllBookings
            // 
            this.btnDelete_AllBookings.Location = new System.Drawing.Point(114, 125);
            this.btnDelete_AllBookings.Name = "btnDelete_AllBookings";
            this.btnDelete_AllBookings.Size = new System.Drawing.Size(102, 23);
            this.btnDelete_AllBookings.TabIndex = 23;
            this.btnDelete_AllBookings.Text = "DELETE";
            this.btnDelete_AllBookings.UseVisualStyleBackColor = true;
            this.btnDelete_AllBookings.Click += new System.EventHandler(this.btnDelete_AllBookings_Click);
            // 
            // spinDeleteAll_Bookings
            // 
            this.spinDeleteAll_Bookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinDeleteAll_Bookings.Location = new System.Drawing.Point(116, 80);
            this.spinDeleteAll_Bookings.Name = "spinDeleteAll_Bookings";
            this.spinDeleteAll_Bookings.Size = new System.Drawing.Size(100, 22);
            this.spinDeleteAll_Bookings.TabIndex = 21;
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
            // DeleteAllBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 328);
            this.Controls.Add(this.groupDeleteAllBookings);
            this.Name = "DeleteAllBookings";
            this.Text = "DeleteAllBookings";
            this.Load += new System.EventHandler(this.DeleteAllBookings_Load);
            this.groupDeleteAllBookings.ResumeLayout(false);
            this.groupDeleteMovieID.ResumeLayout(false);
            this.groupDeleteMovieID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinDel_Movies)).EndInit();
            this.groupDeleteCustomersID.ResumeLayout(false);
            this.groupDeleteCustomersID.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupDeleteMovieID;
        private System.Windows.Forms.Label lblDeleteMovies;
        private System.Windows.Forms.Label lblMovie_ID;
        private System.Windows.Forms.Button btnDel_WithMovieID;
        private System.Windows.Forms.NumericUpDown spinDel_Movies;
        private System.Windows.Forms.GroupBox groupDeleteCustomersID;
    }
}