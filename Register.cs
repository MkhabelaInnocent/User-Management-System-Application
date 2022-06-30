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
    public partial class Register : Form
    {
        SqlConnection con = new SqlConnection("Data Source=sqlserver.dynamicdna.co.za;Initial Catalog=User-Management-System-Innocent;User ID=BBD;Password=");
        public Register()
        {
            InitializeComponent();
        }

        private void registerB_Click(object sender, EventArgs e)
        {
            if (usernameT.Text.Length > 0 && passwordT.Text.Length > 0 && fnamesT.Text.Length > 0)
            {
                try
                {
           
                    con.Open();

                    SqlCommand com = new SqlCommand("INSERT INTO Customer VALUES('"+fnamesT.Text+"','"+usernameT.Text+"','"+passwordT.Text+"')", con);
                    try
                    {
                        com.ExecuteNonQuery();
                        MessageBox.Show("Congratulation you have registered");

                        fnamesT.Clear();
                        usernameT.Clear();
                        passwordT.Clear();

                        fnamesT.Focus();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Failed to register please contact the system admin");
                    }
                    con.Close();


                }
                catch (Exception)
                {

                    MessageBox.Show("Failed to connect to the database");
                }

            }
            else
                MessageBox.Show("Failed to register please contact the system admin");
        }
    }
}
