using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ADONetDataset
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlDataAdapter da = new SqlDataAdapter("spGettingDate", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataSet ds = new DataSet();
                da.Fill(ds);

                //using Tables collection property to display both tables on GridView.
                //By using indexes will make the code look cleaner and readable.
                ds.Tables[0].TableName = "Product";
                ds.Tables[1].TableName = "Categories";

                GridView1.DataSource = ds.Tables["Product"];
                GridView1.DataBind();

                GridView2.DataSource = ds.Tables["Categories"];
                GridView2.DataBind();
            }

        }
    }
}