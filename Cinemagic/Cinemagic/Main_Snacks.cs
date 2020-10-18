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
    public partial class Main_Snacks : Form
    {
        private string connection;
        private SqlCommand command;
        private DataTable dt = new DataTable();
        private SqlDataReader dr;
        private bool isInvalid_SnackInputs;
        private bool isInvalid_TransactionInputs;

        public Main_Snacks()
        {
            InitializeComponent();
        }

        private void setColors()
        {
            foreach (GroupBox box in this.Controls)
            {
                box.BackColor = Color.LightSkyBlue;
            }
            groupMaintain_Snacks.BackColor = Color.DodgerBlue;
            groupTransact_Details.BackColor = Color.DodgerBlue;
            groupDeleteTransacts.BackColor = Color.DodgerBlue;
        }

        private void Main_Snacks_Load(object sender, EventArgs e)
        {
            isInvalid_SnackInputs = false;
            isInvalid_TransactionInputs = false;
            this.BackgroundImage = Cinemagic.Properties.Resources.System_Light;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            setColors();
            dbGridSnacks.Font = new Font(DefaultFont, FontStyle.Regular);
            dbGridSnacks.ColumnHeadersDefaultCellStyle.Font = new Font(DefaultFont, FontStyle.Bold);
            dbTransaction_Details.Font = new Font(DefaultFont, FontStyle.Regular);
            dbTransaction_Details.ColumnHeadersDefaultCellStyle.Font = new Font(DefaultFont, FontStyle.Bold);
            dbGridTransact_Dates.Font = new Font(DefaultFont, FontStyle.Regular);
            dbGridTransact_Dates.ColumnHeadersDefaultCellStyle.Font = new Font(DefaultFont, FontStyle.Bold);
            spinID.Maximum = Int32.MaxValue;
            spinQuantity.Maximum = 300;
            spinSnack_ID.Maximum = Int32.MaxValue;
            spinDeleteAll.Maximum = Int32.MaxValue;
            DisplayDates();
            DisplaySnacks();
            DisplayTransact_Details();
        }

        private void RenameDateColumns()
        {
            dbGridTransact_Dates.Columns[1].HeaderCell.Value = "Date";
        }

        private void RenameTransactionColumns()
        {
            dbTransaction_Details.Columns[2].HeaderCell.Value = "Quantity";
            dbTransaction_Details.Columns[3].HeaderCell.Value = "Total (R)";
        }

        private void RenameSnackColumns()
        {
            dbGridSnacks.Columns[1].HeaderCell.Value = "Item";
            dbGridSnacks.Columns[2].HeaderCell.Value = "Description";
            dbGridSnacks.Columns[3].HeaderCell.Value = "Quantity";
            dbGridSnacks.Columns[4].HeaderCell.Value = "Unit Cost (R)";
            dbGridSnacks.Columns[5].HeaderCell.Value = "Price (R)";
        }

        private void DisplaySnacks()
        {
            dbGridSnacks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Main cinema = new Main();
            connection = cinema.constr;
            cinema.conn = new SqlConnection(connection);
            cinema.conn.Open();
            string select_snacks = "SELECT * FROM SNACK";
            cinema.com = new SqlCommand(select_snacks, cinema.conn);
            cinema.adap = new SqlDataAdapter();
            cinema.ds = new DataSet();
            cinema.adap = new SqlDataAdapter(select_snacks, cinema.conn);
            cinema.adap.Fill(cinema.ds, "Snacks");
            dbGridSnacks.DataSource = cinema.ds;
            dbGridSnacks.DataMember = "Snacks";
            RenameSnackColumns();
            for (int i = 0; i < this.dbGridSnacks.Columns.Count; i++)
            {
                if (i == 4 || i == 5)
                {
                    this.dbGridSnacks.Columns[i].DefaultCellStyle.Format = "0.00";
                }
            }
            cinema.conn.Close();
        }

        private void DisplayTransact_Details()
        {
            dbTransaction_Details.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Main cinema = new Main();
            connection = cinema.constr;
            cinema.conn = new SqlConnection(connection);
            cinema.conn.Open();
            string select_details = "SELECT * FROM SNACK_TRANSACTION";
            cinema.com = new SqlCommand(select_details, cinema.conn);
            cinema.adap = new SqlDataAdapter();
            cinema.ds = new DataSet();
            cinema.adap = new SqlDataAdapter(select_details, cinema.conn);
            cinema.adap.Fill(cinema.ds, "Transaction");
            dbTransaction_Details.DataSource = cinema.ds;
            dbTransaction_Details.DataMember = "Transaction";
            RenameTransactionColumns();
            for (int i = 0; i < this.dbTransaction_Details.Columns.Count; i++)
            {
                if (i == 3)
                {
                    this.dbTransaction_Details.Columns[i].DefaultCellStyle.Format = "0.00";
                }
            }
            cinema.conn.Close();
        }

        private void DisplayDates()
        {
            dbGridTransact_Dates.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Main cinema = new Main();
            connection = cinema.constr;
            cinema.conn = new SqlConnection(connection);
            cinema.conn.Open();
            string select_dates = "SELECT * FROM SNACK_SALE";
            cinema.com = new SqlCommand(select_dates, cinema.conn);
            cinema.adap = new SqlDataAdapter();
            cinema.ds = new DataSet();
            cinema.adap = new SqlDataAdapter(select_dates, cinema.conn);
            cinema.adap.Fill(cinema.ds, "Dates");
            dbGridTransact_Dates.DataSource = cinema.ds;
            dbGridTransact_Dates.DataMember = "Dates";
            RenameDateColumns();
            cinema.conn.Close();
        }

        private bool CheckEmptySnackInputs()
        {
            bool isEmpty = false;
            if (String.IsNullOrEmpty(txtItem.Text) || String.IsNullOrEmpty(txtDescription.Text) || String.IsNullOrEmpty(txtUnit_Cost.Text) || String.IsNullOrEmpty(txtPrice.Text))
            {
                isEmpty = true;
            }
            return isEmpty;
        }

        private bool CheckEmptyTransactInputs()
        {
            bool isEmpty = false;
            if (String.IsNullOrEmpty(txtTotal.Text))
            {
                isEmpty = true;
            }
            return isEmpty;
        }


        private void AddSnacks()
        {
            if (CheckEmptySnackInputs())
            {
                MessageBox.Show("Please ensure all inputs contain a value", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (isInvalid_SnackInputs)
                {
                    MessageBox.Show("Please ensure all inputs contain the correct types and format", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Main cinema = new Main();
                    connection = cinema.constr;
                    try
                    {
                        string insert_snacks = @"INSERT INTO SNACK VALUES(@Snack_Name,@Snack_Description,@Snack_Quantity,@Snack_UnitCost,@Snack_Price)";
                        cinema.conn = new SqlConnection(connection);
                        cinema.conn.Open();
                        cinema.com = new SqlCommand(insert_snacks, cinema.conn);
                        cinema.com.Parameters.AddWithValue("@Snack_Name", txtItem.Text);
                        cinema.com.Parameters.AddWithValue("@Snack_Description", txtDescription.Text);
                        cinema.com.Parameters.AddWithValue("@Snack_Quantity", spinQuantity.Value);
                        cinema.com.Parameters.AddWithValue("@Snack_UnitCost", decimal.Parse(txtUnit_Cost.Text));
                        cinema.com.Parameters.AddWithValue("@Snack_Price", decimal.Parse(txtPrice.Text));
                        cinema.com.ExecuteNonQuery();
                        MessageBox.Show("Snack have been added successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cinema.conn.Close();
                        DisplaySnacks();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + " Failed to add snack... try again please", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void AddTransaction()
        {
            if (CheckEmptyTransactInputs())
            {
                MessageBox.Show("Please ensure all inputs contain a value", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (isInvalid_TransactionInputs)
                {
                    MessageBox.Show("Please ensure all inputs contain the correct types and format", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Main cinema = new Main();
                    connection = cinema.constr;
                    SqlCommand cmd;
                    SqlCommand comm;
                    try
                    {
                        string insert_date = $"INSERT INTO SNACK_SALE VALUES('{System.DateTime.Now.ToString("yyyy/MM/dd")}')";
                        string select_date = @"SELECT TOP 1 * FROM SNACK_SALE ORDER BY Snack_Sale_ID DESC";
                        string insert_transaction = @"INSERT INTO SNACK_TRANSACTION VALUES(@Snack_Sale_ID,@Snack_ID,@Quantity_Ordered,@Unit_Price)";
                        cinema.conn = new SqlConnection(connection);
                        cinema.conn.Open();
                        cinema.com = new SqlCommand(insert_transaction, cinema.conn);
                        cmd = new SqlCommand(insert_date, cinema.conn);
                        cmd.ExecuteNonQuery();
                        comm = new SqlCommand(select_date, cinema.conn);
                        dr = comm.ExecuteReader();
                        if (dr.Read())
                        {
                            cinema.com.Parameters.AddWithValue("@Snack_Sale_ID", dr.GetValue(0));
                            cinema.com.Parameters.AddWithValue("@Snack_ID", spinSnack_ID.Value);
                            cinema.com.Parameters.AddWithValue("@Quantity_Ordered", spinQuantity_Ordered.Value);
                            cinema.com.Parameters.AddWithValue("@Unit_Price", decimal.Parse(txtTotal.Text));
                            cinema.com.ExecuteNonQuery();
                            cinema.conn.Close();
                            MessageBox.Show("The transaction have been added successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DisplayTransact_Details();
                            DisplayDates();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Transaction Date", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + " Failed to add transaction... try again please", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void UpdateSnacks()
        {
            dt.Clear();
            if (CheckEmptySnackInputs())
            {
                MessageBox.Show("Please ensure all inputs contain a value", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (isInvalid_SnackInputs)
                {
                    MessageBox.Show("Please ensure all inputs contain the correct types and format", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Main cinema = new Main();
                    cinema.conn = new SqlConnection(connection);
                    string select_snacks = "SELECT * FROM SNACK WHERE Snack_ID = " + spinFill_SnackID.Value.ToString() + ";";
                    string update_snacks = $"UPDATE SNACK SET Snack_Name = '{txtItem.Text}', Snack_Description = '{txtDescription.Text}', Snack_Quantity = {spinQuantity.Value.ToString()}," +
                    $"Snack_UnitCost = CAST(REPLACE('{txtUnit_Cost.Text}', ',', '.') AS DECIMAL(10, 2)), " +
                    $"Snack_Price = CAST(REPLACE('{txtPrice.Text}', ',', '.') AS DECIMAL(10, 2)) WHERE Snack_ID = {spinFill_SnackID.Value.ToString()}";
                    cinema.com = new SqlCommand(update_snacks, cinema.conn);
                    command = new SqlCommand(select_snacks, cinema.conn);
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
                            DisplaySnacks();
                            MessageBox.Show("Snack updates successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("The selected Snack_ID does not exist!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message + " Failed to update snack...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void UpdateTransactions()
        {
            dt.Clear();
            if (CheckEmptyTransactInputs())
            {
                MessageBox.Show("Please ensure all inputs contain a value", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (isInvalid_TransactionInputs)
                {
                    MessageBox.Show("Please ensure all inputs contain the correct types and format", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Main cinema = new Main();
                    cinema.conn = new SqlConnection(connection);
                    string select_transactions = "SELECT * FROM SNACK_TRANSACTION WHERE Snack_Sale_ID = " + spinFill_SnackSaleID.Value.ToString() + ";";
                    string update_transactions = $"UPDATE SNACK_TRANSACTION SET Snack_ID = '{spinSnack_ID.Value.ToString()}',  Quantity_Ordered = " +
                    $"{spinQuantity_Ordered.Value.ToString()}, Unit_Price = CAST(REPLACE('{txtTotal.Text}', ',', '.') AS DECIMAL(10, 2)) WHERE Snack_Sale_ID = { spinFill_SnackSaleID.Value.ToString()}";
                    cinema.com = new SqlCommand(update_transactions, cinema.conn);
                    command = new SqlCommand(select_transactions, cinema.conn);
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
                            DisplayTransact_Details();
                            MessageBox.Show("Transaction updated successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("The selected Snack_Sale_ID does not exist!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message + " Failed to update transaction...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void FillSnacks()
        {
            Main cinema = new Main();
            string select_snacks = "SELECT * FROM SNACK WHERE Snack_Id = " + spinFill_SnackID.Value.ToString();
            try
            {
                cinema.conn = new SqlConnection(cinema.constr);
                cinema.conn.Open();
                cinema.com = new SqlCommand(select_snacks, cinema.conn);
                SqlDataReader dr = cinema.com.ExecuteReader();
                if (dr.Read())
                {
                    txtItem.Text = dr.GetValue(1).ToString();
                    txtDescription.Text = dr.GetValue(2).ToString();
                    spinQuantity.Value = (int)dr.GetValue(3);
                    txtUnit_Cost.Text = dr.GetValue(4).ToString();
                    txtPrice.Text = dr.GetValue(5).ToString();
                }
                else
                {
                    MessageBox.Show("Please enter a valid Snack_ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cinema.conn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message+" Failed to fill inputs with data from selected record", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillTransactions()
        {
            Main cinema = new Main();
            string select_transactions = "SELECT * FROM SNACK_TRANSACTION WHERE Snack_Sale_Id = " + spinFill_SnackSaleID.Value.ToString();
            try
            {
                cinema.conn = new SqlConnection(cinema.constr);
                cinema.conn.Open();
                cinema.com = new SqlCommand(select_transactions, cinema.conn);
                SqlDataReader dr = cinema.com.ExecuteReader();
                if (dr.Read())
                {
                    spinSnack_ID.Value = int.Parse(dr.GetValue(1).ToString());
                    spinQuantity_Ordered.Value = int.Parse(dr.GetValue(2).ToString());
                    txtTotal.Text = dr.GetValue(3).ToString();
                }
                else
                {
                    MessageBox.Show("Please enter a valid Snack_Sale_ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cinema.conn.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + " Failed to fill inputs with data from selected record", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteSnacks()
        {
            dt.Clear();
            Main cinema = new Main();
            string select_snacks = "SELECT * FROM SNACK WHERE Snack_ID = " + spinID.Value.ToString() + ";";
            SqlCommand cmd;
            try
            {
                string delete_snack = "DELETE FROM SNACK WHERE Snack_Id = " + spinID.Value.ToString();
                cinema.conn = new SqlConnection(cinema.constr);
                cinema.conn.Open();
                cinema.com = new SqlCommand(select_snacks, cinema.conn);
                cmd = new SqlCommand(delete_snack, cinema.conn);
                cinema.adap = new SqlDataAdapter();
                cinema.adap.SelectCommand = cinema.com;
                cinema.adap.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    cmd.ExecuteNonQuery();
                    cinema.conn.Close();
                    MessageBox.Show("Snack was deleted successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplaySnacks();
                }
                else
                {
                    MessageBox.Show("Snack_ID does not exist", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException sql_err)
            {
                int err_num = sql_err.Number;
                if (err_num == 547)
                {
                    MessageBox.Show($"Failed to delete record... Please delete all records in Transaction Details with Snack_ID {spinID.Value}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(sql_err.Message + " Failed to delete record...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + " Failed to delete record...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteAllTransactions()
        {
            dt.Clear();
            Main cinema = new Main();
            string select_transactions = "SELECT * FROM SNACK_TRANSACTION WHERE Snack_ID = " + spinDeleteAll.Value.ToString() + ";";
            SqlCommand cmd;
            try
            {
                string delete_all = "DELETE FROM SNACK_TRANSACTION WHERE Snack_Id = " + spinDeleteAll.Value.ToString();
                cinema.conn = new SqlConnection(cinema.constr);
                cinema.conn.Open();
                cinema.com = new SqlCommand(select_transactions, cinema.conn);
                cmd = new SqlCommand(delete_all, cinema.conn);
                cinema.adap = new SqlDataAdapter();
                cinema.adap.SelectCommand = cinema.com;
                cinema.adap.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    cmd.ExecuteNonQuery();
                    cinema.conn.Close();
                    MessageBox.Show($"Transactions with Snack_ID {spinDeleteAll.Value} deleted successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayTransact_Details();
                }
                else
                {
                    MessageBox.Show("Snack_ID does not exist", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + " Failed to delete selected records...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteTransactions()
        {
            dt.Clear();
            Main cinema = new Main();
            string select_transactions = "SELECT * FROM SNACK_TRANSACTION WHERE Snack_ID = " + spinDelete_TransactID.Value.ToString() + ";";
            SqlCommand cmd;
            try
            {
                string delete_transaction = "DELETE FROM SNACK_TRANSACTION WHERE Snack_Sale_Id = " + spinDelete_TransactID.Value.ToString();
                cinema.conn = new SqlConnection(cinema.constr);
                cinema.conn.Open();
                cinema.com = new SqlCommand(select_transactions, cinema.conn);
                cmd = new SqlCommand(delete_transaction, cinema.conn);
                cinema.adap = new SqlDataAdapter();
                cinema.adap.SelectCommand = cinema.com;
                cinema.adap.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    cmd.ExecuteNonQuery();
                    cinema.conn.Close();
                    MessageBox.Show("Transaction was deleted successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayTransact_Details();
                }
                else
                {
                    MessageBox.Show("Snack_Sale_ID does not exist", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + " Failed to delete record...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Snacks_Click(object sender, EventArgs e)
        {
            AddSnacks();
        }

        private void txtUnit_Cost_Validating(object sender, CancelEventArgs e)
        {
            isInvalid_SnackInputs = false;
            decimal unit_cost;
            if (!decimal.TryParse(txtUnit_Cost.Text,out unit_cost))
            {
                isInvalid_SnackInputs = true;
                MessageBox.Show("Must enter a decimal value", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFill_Snacks_Click(object sender, EventArgs e)
        {
            FillSnacks();
        }

        private void txtPrice_Validating(object sender, CancelEventArgs e)
        {
            isInvalid_SnackInputs = false;
            decimal price;
            if (!decimal.TryParse(txtPrice.Text, out price))
            {
                isInvalid_SnackInputs = true;
                MessageBox.Show("Must enter a decimal value", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Snacks_Click(object sender, EventArgs e)
        {
            UpdateSnacks();
        }

        private void btnDelete_Snack_Click(object sender, EventArgs e)
        {
            DeleteSnacks();
        }

        private void btnAdd_Transact_Click(object sender, EventArgs e)
        {
            AddTransaction();
        }

        private void btnFill_Transact_Click(object sender, EventArgs e)
        {
            FillTransactions();
        }

        private void btnUpdate_Transact_Click(object sender, EventArgs e)
        {
            UpdateTransactions();
        }

        private void btnDelete_Transaction_Click(object sender, EventArgs e)
        {
            DeleteTransactions();
        }

        private void btnDelete_All_Click(object sender, EventArgs e)
        {
            DeleteAllTransactions();
        }

        private void txtTotal_Validating(object sender, CancelEventArgs e)
        {
            isInvalid_TransactionInputs = false;
            decimal total;
            if (!decimal.TryParse(txtTotal.Text, out total))
            {
                isInvalid_TransactionInputs = true;
                MessageBox.Show("Must enter a decimal value", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            isInvalid_SnackInputs = false;
            if (txtDescription.Text.Any(char.IsDigit) || !txtDescription.Text.Any(ch => Char.IsLetterOrDigit(ch)))
            {
                isInvalid_SnackInputs = true;
                MessageBox.Show("Snack Description cannot contain numbers or special characters", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
