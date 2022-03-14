using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace login_form
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void logindata(object sender, EventArgs e)
        {
            SqlConnection con = null;
            string strcon = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;

            try
            {
                string Username = username.Text;
                string pass = password.Text;
                con = new SqlConnection(strcon);
                string sql = "select u.id, u.username,u.password, r.name as role from register u join role r on u.roleid = r.id where u.username ='" + Username + "' and u.password = '" + pass + "'";

                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader sda = cmd.ExecuteReader();

                while (sda.Read())
                {
                    string id = sda["id"].ToString();
                    string username = sda["Username"].ToString();
                    string passWord = sda["pass"].ToString();
                    string role = sda["role"].ToString();
                    if (Username == username && pass == passWord)
                    {
                        if (role == "Admin")
                        {
                            Response.Redirect("admin");
                        }
                        else if (role == "User")
                        {
                            Response.Redirect("user");
                        }
                        else
                        {
                            Response.Redirect("error");
                        }
                        //Response.Redirect("welcome");
                    }
                    else
                    {
                        Response.Redirect("404");
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
    }
}