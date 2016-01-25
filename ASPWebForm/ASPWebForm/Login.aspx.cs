using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace ASPWebForm
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
            conn.Open();
            string checkuser = "select count(*) from UserData where UserName='" + txtUsername.Text + "'";
            SqlCommand com = new SqlCommand(checkuser, conn);
            int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
            conn.Close();
            if (temp == 1)
            {
                conn.Open();
                string checkPassword = "select password from UserData where UserName='" + txtUsername.Text + "'";
                SqlCommand passCom = new SqlCommand(checkPassword, conn);
                string password = passCom.ExecuteScalar().ToString().Replace(" ","");
                if (password == txtPassword.Text)
                {
                    Session["New"] = txtUsername.Text;
                    Response.Write("Password is Correct");
                    Response.Redirect("Manager.aspx");
                }
                else
                {
                    Response.Write("Password is not correct");
                }
            }

            else
            {
              Response.Write("UserName is not correct");
            }
       }
    }
}
