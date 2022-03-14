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
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void registerdata(object sender, EventArgs e)
        {
            SqlConnection con = null;
            string strcon = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
           
            try
            {
                string Username = username.Text;
                string pass = password.Text;
                string City = city.Text;
                con = new SqlConnection(strcon);
                string sql = "insert into register(username,password,city) values('" + Username + "','" + pass + "','" + City + "')";

                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                int Status = cmd.ExecuteNonQuery();
                if (Status > 0)
                {
                    // result.Text="successfully inserted";
                    // Response.Write("<script>alert('Inserted successfully!')</script>");
                    Response.Redirect("Default.aspx");
                }
                else
                {
                    //result.Text = "not inserted";
                    Response.Redirect("About.aspx");
                    //Response.Write("<script>alert('Enable To Insert')</script>");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally{
                con.Close();
            }

        }
    }
}