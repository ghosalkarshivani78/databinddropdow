using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace login_form
{
    public partial class userForm : System.Web.UI.Page
    {
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //cityList
                //  static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
                if (!Page.IsPostBack)
                {
                    GetStudentList();
                }

               
               // con.Open();
              

               

                //  con.Close();
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
        public void GetStudentList()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from city_fk", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            cityList.DataSource = dt;
            cityList.DataBind();
            //SqlDataAdapter sda1 = new SqlDataAdapter("select p.id, p.name, p.email, p.cityid, cf.name as cityname from person1 p join  city_fk cf ON p.cityid = cf.cityid", con);

            //// Bind Data
            //DataTable dt1 = new DataTable();
            //sda1.Fill(dt1);
            //userList.DataSource = dt1;
            //userList.DataBind();
            con.Close();

        }
        protected void submit(object sender, EventArgs e)
        {
            string sql = "insert into person1(name,email,number,cityid) values('" + name.Text + "','" + email.Text + "','" + number.Text + "','" + Request.Form["cityid"] + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
           int status= cmd.ExecuteNonQuery();
            if (status > 0)
            {
              
                Response.Redirect("userForm");
            }
            else
            {
                Response.Redirect("/Default.aspx");
            }
            con.Close();
        }
    }
}