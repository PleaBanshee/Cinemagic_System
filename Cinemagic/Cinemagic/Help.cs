using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomProj
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void Help_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Cinemagic.Properties.Resources.System_Light;
            tabBookings.BackColor = Color.Salmon;
            tabMovies.BackColor = Color.Salmon;
            tabSnacks.BackColor = Color.Salmon;

            picBookings.Image = Cinemagic.Properties.Resources.BookingForm;
            picBookings.BackgroundImageLayout = ImageLayout.Stretch;
            picCustomers.Image = Cinemagic.Properties.Resources.CustomerForm;
            picCustomers.BackgroundImageLayout = ImageLayout.Stretch;
            picDeleteAll_Bookings.Image = Cinemagic.Properties.Resources.DeleteAllBookings;
            picDeleteAll_Bookings.BackgroundImageLayout = ImageLayout.Stretch;

            picMovies.Image = Cinemagic.Properties.Resources.MoviesForm;
            picMovies.BackgroundImageLayout = ImageLayout.Stretch;
            picGenre.Image = Cinemagic.Properties.Resources.GenresForm;
            picGenre.BackgroundImageLayout = ImageLayout.Stretch;
            picDeleteAll_Movies.Image = Cinemagic.Properties.Resources.DeleteAllMoviesForm;
            picDeleteAll_Movies.BackgroundImageLayout = ImageLayout.Stretch;

            picSnacks.Image = Cinemagic.Properties.Resources.SnacksForm;
            picSnacks.BackgroundImageLayout = ImageLayout.Stretch;
            picTransactions.Image = Cinemagic.Properties.Resources.TransactionForm;
            picTransactions.BackgroundImageLayout = ImageLayout.Stretch;
            picDeleteAll_Transactions.Image = Cinemagic.Properties.Resources.DeleteAllTransactionsForm;
            picDeleteAll_Transactions.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
