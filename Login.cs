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

namespace User_Management_System_Innocent
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection("");
        public Login()
        {
            InitializeComponent();
        }

        private void loginB_Click(object sender, EventArgs e)
        {
            if (usernameT.Text.Length > 0 && passwordT.Text.Length > 0)
            {
                try
                {
                    con.Open();



                    con.Close();

                }
                catch (Exception)
                {

                    MessageBox.Show("Failed to connect to the DB");
                }

            }
            else
                MessageBox.Show("All Fields are required");
        }

        private void fpasswordB_Click(object sender, EventArgs e)
        {
            Forgot_Password fg = new Forgot_Password();
            fg.Show();
            this.Hide();
        }

        private void registerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register rg = new Register();
            rg.Show();
            this.Hide();
        }
    }
}
