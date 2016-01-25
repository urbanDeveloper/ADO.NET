using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace AdoNetSqlCommands
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS)) 
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Insert into tblProduct values (4, 'Calculators', 100, 230)";
                cmd.Connection = con;
                con.Open();

                //DELETE
                cmd.CommandText = " Delete from tblProduct where ProductId = 4";
                int TotalRowsAffected = cmd.ExecuteNonQuery();
                Response.Write("Total Rows Deleted= " + TotalRowsAffected.ToString() + "</br>");

                //INSERT
                cmd.CommandText = " Insert into tblProduct values (4, 'Calculators', 100, 230)";
                TotalRowsAffected = cmd.ExecuteNonQuery();
                Response.Write("Total Rows Inserted= " + TotalRowsAffected.ToString() + "</br>");

                //UPDATE
                cmd.CommandText = " update tblProduct set QtyAvailable = 200 where ProductId = 2";
                TotalRowsAffected = cmd.ExecuteNonQuery();
                Response.Write("Total Rows Updated= " + TotalRowsAffected.ToString() + "</br>");

                //Exexute Scalar to return one value.- sql = Select Count(ProductId) From tblProduct
                //int TotalRows = (int)cmd.ExecuteScalar();
                //Response.Write("Total Rows= " + TotalRows.ToString());

                //Execute Reader Method.
                //GridView1.DataSource = cmd.ExecuteReader();
                //GridView1.DataBind();

            }
        }
    }
}