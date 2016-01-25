using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace ADOStoredProcedureOutputParams
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var CS = ConfigurationManager.ConnectionStrings["DBMS"].ConnectionString;

            using(SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("spAddEmployee", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Name", txtEmp.Text);
                cmd.Parameters.AddWithValue("@Gender", drpGender.SelectedValue);
                cmd.Parameters.AddWithValue("@Salary", txtSalary.Text);

                //output employee id
                SqlParameter outputParms = new SqlParameter();
                //get the parameter name
                outputParms.ParameterName = "@EmployeeId";
                //sql datatype = int
                outputParms.SqlDbType = System.Data.SqlDbType.Int;
                //type of parameter(the direction)
                outputParms.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(outputParms);

                con.Open();
                //inserting a new row
                cmd.ExecuteNonQuery();

                string EmpId = outputParms.Value.ToString();
                lblMessage.Text = "Employee Id = " + EmpId;
                con.Close();

            }
        }
    }
}