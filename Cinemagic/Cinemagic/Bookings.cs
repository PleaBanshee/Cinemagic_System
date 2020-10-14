using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using RandomProj;

namespace RandomProj
{
    public partial class Bookings_Movies : Form
    {
        private string connection;
        private SqlCommand command;
        private DataTable dt = new DataTable();
        private SqlDataReader dr;

        public Bookings_Movies()
        {
            InitializeComponent();
        }

        private void Bookings_Movies_Load(object sender, EventArgs e)
        {
            toolTipBack.SetToolTip(btnMain,"Go back to Cinemagic");
            DisplayGenres();
            DisplayMovies();
            cmbAge.Items.Add("General Audiences");
            cmbAge.Items.Add("PG-13");
            cmbAge.Items.Add("PG");
            cmbAge.Items.Add("Restricted Under 17");
            cmbAge.Items.Add("NC-17");
        }

        #region BOOKINGS

        #endregion

        #region MOVIES

        private void DisplayMovies()
        {
            dbMovies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Main cinema = new Main();
            connection = cinema.constr;
            cinema.conn = new SqlConnection(connection);
            cinema.conn.Open();
            string select_snacks = "SELECT * FROM MOVIE";
            cinema.com = new SqlCommand(select_snacks, cinema.conn);
            cinema.adap = new SqlDataAdapter();
            cinema.ds = new DataSet();
            cinema.adap = new SqlDataAdapter(select_snacks, cinema.conn);
            cinema.adap.Fill(cinema.ds, "Movies");
            dbMovies.DataSource = cinema.ds;
            dbMovies.DataMember = "Movies";
            cinema.conn.Close();
        }

        private void DisplayGenres()
        {
            dbGenres.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Main cinema = new Main();
            connection = cinema.constr;
            cinema.conn = new SqlConnection(connection);
            cinema.conn.Open();
            string select_snacks = "SELECT * FROM GENRE";
            cinema.com = new SqlCommand(select_snacks, cinema.conn);
            cinema.adap = new SqlDataAdapter();
            cinema.ds = new DataSet();
            cinema.adap = new SqlDataAdapter(select_snacks, cinema.conn);
            cinema.adap.Fill(cinema.ds, "Genres");
            dbGenres.DataSource = cinema.ds;
            dbGenres.DataMember = "Genres";
            cinema.conn.Close();
        }

        private bool CheckEmptyMovieInputs()
        {
            bool isEmpty = false;
            if (String.IsNullOrEmpty(txtMovie.Text) || String.IsNullOrEmpty(txtDuration.Text))
            {
                isEmpty = true;
            }
            return isEmpty;
        }

        private bool CheckEmptyGenreInputs()
        {
            bool isEmpty = false;
            if (String.IsNullOrEmpty(txtDescription.Text))
            {
                isEmpty = true;
            }
            return isEmpty;
        }

        private void AddGenres()
        {
            if (CheckEmptyGenreInputs())
            {
                MessageBox.Show("Please ensure all inputs contain a value", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Main cinema = new Main();
                connection = cinema.constr;
                try
                {
                    string insert_genres = @"INSERT INTO GENRE VALUES(@Genre_Description)";
                    cinema.conn = new SqlConnection(connection);
                    cinema.conn.Open();
                    cinema.com = new SqlCommand(insert_genres, cinema.conn);
                    cinema.com.Parameters.AddWithValue("@Genre_Description", txtDescription.Text);
                    cinema.com.ExecuteNonQuery();
                    MessageBox.Show("Movie Genre has been added successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cinema.conn.Close();
                    DisplayGenres();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " Failed to add Genre... try again please", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddMovies()
        {
            if (CheckEmptyMovieInputs())
            {
                MessageBox.Show("Please ensure all inputs contain a value", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Main cinema = new Main();
                connection = cinema.constr;
                try
                {
                    string insert_movies = @"INSERT INTO MOVIE VALUES(@Movie_Name,@Genre_ID,@Movie_Duration,@Age_Restriction,@Release_Date,@Withdrawal_Date)";
                    cinema.conn = new SqlConnection(connection);
                    cinema.conn.Open();
                    cinema.com = new SqlCommand(insert_movies, cinema.conn);
                    cinema.com.Parameters.AddWithValue("@Movie_Name", txtMovie.Text);
                    cinema.com.Parameters.AddWithValue("@Genre_ID", spinGenre_ID.Value);
                    cinema.com.Parameters.AddWithValue("@Movie_Duration", DateTime.Parse(txtDuration.Text).ToString("HH:mm:ss"));
                    cinema.com.Parameters.AddWithValue("@Age_Restriction", cmbAge.SelectedItem.ToString());
                    cinema.com.Parameters.AddWithValue("@Release_Date", dateRelease.Value.ToString("yyyy/MM/dd"));
                    cinema.com.Parameters.AddWithValue("@Withdrawal_Date", dateWithdrawal.Value.ToString("yyyy/MM/dd"));
                    cinema.com.ExecuteNonQuery();
                    MessageBox.Show("Movie has been added successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cinema.conn.Close();
                    DisplayMovies();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " Failed to add movie... try again please", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FillGenres()
        {
            Main cinema = new Main();
            string select_genres = "SELECT * FROM GENRE WHERE Genre_ID = " + spinFill_GenreID.Value.ToString();
            try
            {
                cinema.conn = new SqlConnection(cinema.constr);
                cinema.conn.Open();
                cinema.com = new SqlCommand(select_genres, cinema.conn);
                SqlDataReader dr = cinema.com.ExecuteReader();
                if (dr.Read())
                {
                    txtDescription.Text = dr.GetValue(1).ToString();
                }
                else
                {
                    MessageBox.Show("Please enter a valid Genre_ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cinema.conn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + " Failed to fill inputs with data from selected record", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillMovies()
        {
            Main cinema = new Main();
            string select_movies = "SELECT * FROM MOVIE WHERE Movie_ID = " + spinMovie_ID.Value.ToString();
            try
            {
                cinema.conn = new SqlConnection(cinema.constr);
                cinema.conn.Open();
                cinema.com = new SqlCommand(select_movies, cinema.conn);
                SqlDataReader dr = cinema.com.ExecuteReader();
                if (dr.Read())
                {
                    txtMovie.Text = dr.GetValue(1).ToString();
                    spinGenre_ID.Value = int.Parse(dr.GetValue(2).ToString());
                    txtDuration.Text = dr.GetValue(3).ToString();
                    cmbAge.SelectedItem = dr.GetValue(4).ToString();
                    dateRelease.Value = DateTime.Parse(dr.GetValue(5).ToString());
                    dateWithdrawal.Value = DateTime.Parse(dr.GetValue(6).ToString());
                }
                else
                {
                    MessageBox.Show("Please enter a valid Snack_ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cinema.conn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + " Failed to fill inputs with data from selected record", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateGenres()
        {
            if (CheckEmptyGenreInputs())
            {
                MessageBox.Show("Please ensure all inputs contain a value", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Main cinema = new Main();
                cinema.conn = new SqlConnection(connection);
                string select_genres = "SELECT * FROM GENRE WHERE Genre_ID = " + spinFill_GenreID.Value.ToString() + ";";
                string update_genres = $"UPDATE GENRE SET Genre_Description = '{txtDescription.Text}' WHERE Genre_ID = {spinFill_GenreID.Value.ToString()}";
                cinema.com = new SqlCommand(update_genres, cinema.conn);
                command = new SqlCommand(select_genres, cinema.conn);
                cinema.adap = new SqlDataAdapter();
                cinema.adap.SelectCommand = command;
                cinema.adap.Fill(dt);
                try
                {
                    cinema.conn.Open();
                    if (dt.Rows.Count > 0)
                    {
                        cinema.com.ExecuteNonQuery();
                        cinema.conn.Close();
                        DisplayGenres();
                        MessageBox.Show("Movie Genre updated successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("The selected Genre_ID does not exist!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message + " Failed to update Genre...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateMovies()
        {
            if (CheckEmptyMovieInputs())
            {
                MessageBox.Show("Please ensure all inputs contain a value", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Main cinema = new Main();
                cinema.conn = new SqlConnection(connection);
                string select_movies = "SELECT * FROM MOVIE WHERE Movie_ID = " + spinMovie_ID.Value.ToString() + ";";
                string update_movies = $"UPDATE MOVIE SET Movie_Name = '{txtMovie.Text}', Genre_ID = {spinGenre_ID.Value}, Movie_Duration = '{txtDuration.Text}'," +
                $"Age_Restriction = '{cmbAge.SelectedItem.ToString()}', " +
                $"Release_Date = '{dateRelease.Value.ToString("yyyy/MM/dd")}', Withdrawal_Date = '{dateWithdrawal.Value.ToString("yyyy/MM/dd")}' WHERE Movie_ID = {spinMovie_ID.Value.ToString()}";
                cinema.com = new SqlCommand(update_movies, cinema.conn);
                command = new SqlCommand(select_movies, cinema.conn);
                cinema.adap = new SqlDataAdapter();
                cinema.adap.SelectCommand = command;
                cinema.adap.Fill(dt);
                try
                {
                    cinema.conn.Open();
                    if (dt.Rows.Count > 0)
                    {
                        cinema.com.ExecuteNonQuery();
                        cinema.conn.Close();
                        DisplayMovies();
                        MessageBox.Show("Movie updates successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("The selected Movie_ID does not exist!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message + " Failed to update movie...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DeleteGenre()
        {
            Main cinema = new Main();
            string select_genre = "SELECT * FROM GENRE WHERE Genre_ID = " + spinDel_GenreID.Value.ToString() + ";";
            SqlCommand cmd;
            try
            {
                string delete_genre = "DELETE FROM GENRE WHERE Genre_Id = " + spinDel_GenreID.Value.ToString();
                cinema.conn = new SqlConnection(cinema.constr);
                cinema.conn.Open();
                cinema.com = new SqlCommand(select_genre, cinema.conn);
                cmd = new SqlCommand(delete_genre, cinema.conn);
                cinema.adap = new SqlDataAdapter();
                cinema.adap.SelectCommand = cinema.com;
                cinema.adap.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    cmd.ExecuteNonQuery();
                    cinema.conn.Close();
                    MessageBox.Show("Movie Genre was deleted successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayGenres();
                }
                else
                {
                    MessageBox.Show("Genre_ID does not exist", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + " Failed to delete record...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteMovie()
        {
            Main cinema = new Main();
            string select_movies = "SELECT * FROM MOVIE WHERE Movie_ID = " + spinDel_MovieID.Value.ToString() + ";";
            SqlCommand cmd;
            try
            {
                string delete_movie = "DELETE FROM MOVIE WHERE Movie_Id = " + spinDel_MovieID.Value.ToString();
                cinema.conn = new SqlConnection(cinema.constr);
                cinema.conn.Open();
                cinema.com = new SqlCommand(select_movies, cinema.conn);
                cmd = new SqlCommand(delete_movie, cinema.conn);
                cinema.adap = new SqlDataAdapter();
                cinema.adap.SelectCommand = cinema.com;
                cinema.adap.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    cmd.ExecuteNonQuery();
                    cinema.conn.Close();
                    MessageBox.Show("Movie was deleted successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayMovies();
                }
                else
                {
                    MessageBox.Show("Movie_ID does not exist", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + " Failed to delete record...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteAllMovies()
        {
            Main cinema = new Main();
            string select_movies = "SELECT * FROM MOVIE WHERE Genre_ID = " + spinDeleteAll_Movies.Value.ToString() + ";";
            SqlCommand cmd;
            try
            {
                string delete_all = "DELETE FROM MOVIE WHERE Genre_ID = " + spinDeleteAll_Movies.Value.ToString();
                cinema.conn = new SqlConnection(cinema.constr);
                cinema.conn.Open();
                cinema.com = new SqlCommand(select_movies, cinema.conn);
                cmd = new SqlCommand(delete_all, cinema.conn);
                cinema.adap = new SqlDataAdapter();
                cinema.adap.SelectCommand = cinema.com;
                cinema.adap.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    cmd.ExecuteNonQuery();
                    cinema.conn.Close();
                    MessageBox.Show($"Movies with Genre_ID {spinDeleteAll_Movies.Value} deleted successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayMovies();
                }
                else
                {
                    MessageBox.Show("Genre_ID does not exist", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + " Failed to delete selected records...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Movie_Click(object sender, EventArgs e)
        {
            AddMovies();
        }

        private void btnFill_Movie_Click(object sender, EventArgs e)
        {
            FillMovies();
        }

        private void btnUpdate_Movie_Click(object sender, EventArgs e)
        {
            UpdateMovies();
        }

        private void btnDelete_Movie_Click(object sender, EventArgs e)
        {
            DeleteMovie();
        }

        private void btnAdd_Genre_Click(object sender, EventArgs e)
        {
            AddGenres();
        }

        private void btnUpdate_Genre_Click(object sender, EventArgs e)
        {
            UpdateGenres();
        }

        private void btnFill_Genres_Click(object sender, EventArgs e)
        {
            FillGenres();
        }

        private void btnDelete_Genres_Click(object sender, EventArgs e)
        {
            DeleteGenre();
        }

        private void btnDelete_AllMovies_Click(object sender, EventArgs e)
        {
            DeleteAllMovies();
        }

        private void txtDuration_Validating(object sender, CancelEventArgs e)
        {
            if (!txtDuration.Text.Contains(':'))
            {
                MessageBox.Show("Please enter Movie duration in format HH:MM:SS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbAge_Validating(object sender, CancelEventArgs e)
        {
            if (cmbAge.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an age restriction...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateRelease_Validating(object sender, CancelEventArgs e)
        {
            if (DateTime.Compare(dateRelease.Value,dateWithdrawal.Value) >= 0)
            {
                MessageBox.Show("Release date cannot be after or on Withdrawal date", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateWithdrawal_Validating(object sender, CancelEventArgs e)
        {
            if (DateTime.Compare(dateWithdrawal.Value, dateRelease.Value) <= 0)
            {
                MessageBox.Show("Withdrawal date cannot be before or on Release date", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (txtDescription.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Movie Genre cannot contain numbers...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void btnMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main_GUI = new Main();
            main_GUI.ShowDialog();
        }
    }
}
