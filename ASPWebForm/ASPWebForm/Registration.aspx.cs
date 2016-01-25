using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Linq.Expressions;

namespace ASPWebForm
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
                conn.Open();
                string checkuser = "select count(*) from UserData where UserName='" + txtUserName.Text + "'";
                SqlCommand com = new SqlCommand(checkuser, conn);
                int temp = Convert.ToInt32(com.ExecuteScalar().ToString());

                if (temp == 1)
                {
                    Response.Write("User already exists");
                }

                conn.Close();

            }

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
                conn.Open();
                string insertQurey ="insert into UserData (UserName,Email,Password,Country) values(@Uname, @email, @password, @country)";
                SqlCommand cmd = new SqlCommand(insertQurey, conn);
                cmd.Parameters.AddWithValue("@Uname", txtUserName.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@country", drpCountry.SelectedItem.ToString());

                cmd.ExecuteNonQuery();
                Response.Redirect("Manager.aspx");
                Response.Write("Registration was successful");
            }

            catch(Exception ex)
            {
                Response.Write("Error"+ex.ToString());
            }


        }

        }
    }
