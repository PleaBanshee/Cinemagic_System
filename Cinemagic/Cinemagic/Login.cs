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
using System.Threading;

namespace Cinemagic
{
    public partial class Form1 : Form
    {
        private const string USER_NAME = "Admin";
        private const string PASSWORD = "C!n3M@giK";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Cinemagic_Login;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            txtPassword.PasswordChar = '*';
            lblHeading.BackColor = Color.Transparent;
            lblPassword.BackColor = Color.Transparent;
            lblUsername.BackColor = Color.Transparent;
        }

        public void SplashStart()
        {
            Application.Run(new SplashScreen.Form1());
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username;
            string password;
            try
            {
                username = txtUsername.Text;
                password = txtPassword.Text;
                if (username != USER_NAME || password != PASSWORD)
                {
                     MessageBox.Show("Invalid Username or Password!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.Hide();
                    Thread t = new Thread(new ThreadStart(SplashStart));
                    t.Start();
                    Thread.Sleep(5000);
                    t.Abort();
                    this.WindowState = FormWindowState.Normal;
                    Main sys_form = new Main();
                    sys_form.ShowDialog();
                }  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
           

