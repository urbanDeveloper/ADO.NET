using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace SQLDataReaderADO
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBMS"].ConnectionString;

            using (SqlConnection con = new SqlConnection(CS))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select ProductId,ProductName, UnitPrice, (UnitPrice * 0.9) as DiscountedPrice from tblProductInventory",con);
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    GridView1.DataSource = rdr;
                    GridView1.DataBind();

                    ////creating a new object table 
                    //DataTable table = new DataTable();
                    //table.Columns.Add("ID");
                    //table.Columns.Add("Name");
                    //table.Columns.Add("Price");
                    //table.Columns.Add("DiscountedPrice");

                    ////looping through each data object in DataReader using the Read Method. 
                    //while(rdr.Read())
                    //{
                    //    DataRow dataRow = table.NewRow();

                    //    int OriginalPrice = Convert.ToInt32(rdr["UnitPrice"]);
                    //    double DiscountedPrice = OriginalPrice * 0.9;

                    //    dataRow["ID"] = rdr["Id"];
                    //    dataRow["Name"] = rdr["ProductName"];
                    //    dataRow["Price"] = OriginalPrice;
                    //    dataRow["DiscountedPrice"] = DiscountedPrice;
                    //    table.Rows.Add(dataRow);
                    //}

                }
            }
        }
    }
}