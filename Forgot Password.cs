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
    public partial class Forgot_Password : Form
    {
        SqlConnection con = new SqlConnection("");
        
        public Forgot_Password()
        {
            InitializeComponent();
        }

        private void registerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register rg = new Register();
            rg.Show();
            this.Show();
        }

        private void loginB_Click(object sender, EventArgs e)
        {
            Login lg=new Login();
            lg.Show();
            this.Show();
        }

        private void showpasswordB_Click(object sender, EventArgs e)
        {
            if (usernameT.Text.Length > 0)
            {
                try
                {
                 SqlCommand com = new SqlCommand("SELECT Password FROM Customer WHERE Username ='"+usernameT.Text+"" , con);
                    con.Open();
                       dr = com.ExecuteReader();

                    while(dr.Read())
                    {
                        MessageBox.Show("Your password is: " + dr["Password"].ToString());
                    }


                    con.Close();
                }
                catch (Exception)
                {

                    MessageBox.Show("Failed to connect to the database");
                }
            }
            else
                MessageBox.Show("Your username is required");
        }
    }
}
