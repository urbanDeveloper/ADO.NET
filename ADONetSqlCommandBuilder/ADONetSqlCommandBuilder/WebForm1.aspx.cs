using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace ADONetSqlCommandBuilder
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetStudent_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs)) 
            {
                string sqlQurey = "Select * from tblStudents where ID = " + txtStudentID.Text;
                SqlDataAdapter da = new SqlDataAdapter(sqlQurey, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Students");

                ViewState["SQL_QUREY"] = sqlQurey;
                ViewState["DATASET"] = ds;

                if(ds.Tables["Students"].Rows.Count > 0)
                {
                    DataRow dr = ds.Tables["Students"].Rows[0];
                    txtStudentName.Text = dr["Name"].ToString();
                    txtTotalMarks.Text = dr["TotalMarks"].ToString();
                    ddlGender.SelectedValue = dr["Gender"].ToString();
                }
                else 
                {
                    lblStatus.ForeColor = System.Drawing.Color.Red;
                    lblStatus.Text = "No Student record with ID = " + txtStudentID.Text;
                }

            }

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
             string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
             using (SqlConnection con = new SqlConnection(cs)) 
             {
                 SqlDataAdapter da = new SqlDataAdapter();
                 da.SelectCommand = new SqlCommand((string)ViewState["SQL_QUERY"], con);

                 SqlCommandBuilder builder = new SqlCommandBuilder();
                 builder.DataAdapter = da;
                 
                 DataSet ds = (DataSet)ViewState["DATASET"];

                 if (ds.Tables["Students"].Rows.Count > 0) 
                 {
                     DataRow dr = ds.Tables["Students"].Rows[0];
                     dr["Name"] = txtStudentName.Text;
                     dr["Gender"] = ddlGender.SelectedValue;
                     dr["TotalMarks"] = txtTotalMarks.Text;
                 }
                 //this line not working saying command error.
                 int rowsupdated = da.Update(ds, "Students");
                 if(rowsupdated > 0)
                 {
                  lblStatus.ForeColor = System.Drawing.Color.Green;
                  lblStatus.Text = rowsupdated.ToString() + "rows(s) updated";
                 }
                 else
                 {
                     lblStatus.ForeColor = System.Drawing.Color.Red;
                     lblStatus.Text = " No rows(s) updated";

                 }
             }
        }
    }
}