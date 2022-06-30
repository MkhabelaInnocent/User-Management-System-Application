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
        SqlDataReader dr;
        SqlConnection con = new SqlConnection("Data Source=sqlserver.dynamicdna.co.za;Initial Catalog=User-Management-System-Innocent;User ID=BBD;Password=");
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
                     SqlCommand com = new SqlCommand("SELECT Username,Password FROM Customer WHERE Username ='"+usernameT.Text+"'AND Password = '"+passwordT.Text+"'", con);
                    dr = com.ExecuteReader();

                    while (dr.Read())
                    {
                        Menu mn = new Menu();
                        mn.Show();
                        this.Hide();
                    }



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
