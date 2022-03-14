using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace login_form
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

           
        }
        protected void registerdata(object sender, EventArgs e)
        {
            SqlConnection con = null;
            string strcon = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            if (confirmpassword.Text != string.Empty || password.Text != string.Empty || username.Text != string.Empty)
            {
                if (password.Text == confirmpassword.Text)
                {
                   SqlCommand cmd = new SqlCommand("select * from login where username='" + username.Text + "'", con);
                   SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("insert into login values(@username,@password)", con);
                        cmd.Parameters.AddWithValue("username", username.Text);
                        cmd.Parameters.AddWithValue("password", password.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected void login(object sender, EventArgs e)
        {
            //this.Hide();
            //Login login = new Login();
            //login.ShowDialog();
        }

    }
}