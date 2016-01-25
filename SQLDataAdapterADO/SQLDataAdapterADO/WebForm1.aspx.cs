using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace SQLDataAdapterADO
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string CS = ConfigurationManager.ConnectionStrings["DBMS"].ConnectionString;
            //using (SqlConnection con = new SqlConnection(CS))
            //{
            //    SqlDataAdapter da = new SqlDataAdapter("spGetProductInventory", con);
            //    da.SelectCommand.CommandType = CommandType.StoredProcedure;
            //    DataSet ds = new DataSet();

            //    da.Fill(ds);
            //    GridView1.DataSource = ds;
            //    GridView1.DataBind();

            //}
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBMS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand("spGetProductByName", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.SelectCommand.Parameters.AddWithValue("@ProductId", TextBox1.Text);
                DataSet ds = new DataSet();
                da.Fill(ds);

                GridView1.DataSource = ds;
                GridView1.DataBind();

            }
        }
    }
}