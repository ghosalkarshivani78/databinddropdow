using SimpleInjector;
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
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void logindata(object sender, EventArgs e)
        {
            SqlConnection con = null;
            string strcon = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;

            if (password.Text != string.Empty || username.Text != string.Empty)
            {

               SqlCommand cmd = new SqlCommand("select * from login where username='" + username.Text + "' and password='" + password.Text + "'", con);
               SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    //dr.Close();
                    //this.Hide();
                    //Home home = new Home();
                    //home.ShowDialog();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected void newaccount(object sender, EventArgs e)
        {
            //object p = this.Hide();
            //Registration registration = new Registration();
            //registration.ShowDialog();
        }
    }
}
