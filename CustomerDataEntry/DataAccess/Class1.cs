using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DataAccess
{
    public class clsSqlServer
    {

        public DataSet getCustomers()
        {
            //ADO.NET code which will insert to SQL Server
            string Connectionstring = ConfigurationManager.ConnectionStrings["DbConn"].ToString();
            SqlConnection objConnection = new SqlConnection(Connectionstring);
            objConnection.Open();
            //command fire SQL
            SqlCommand objCommand = new SqlCommand("SELECT * FROM CustomerTable", objConnection);
            DataSet objDataset = new DataSet();
            SqlDataAdapter objAdapter = new SqlDataAdapter(objCommand);
            objAdapter.Fill(objDataset);
            //bind the data to the UI

            //close connection
            objConnection.Close();
            return objDataset;

        }
        public DataSet getCustomers(string CustomerCode)
        {
            // Getting Customer Data

            //Open connection
            string Connectionstring = ConfigurationManager.ConnectionStrings["DbConn"].ToString();
            SqlConnection objConnection = new SqlConnection(Connectionstring);
            objConnection.Open();
            //command fire SQL
            SqlCommand objCommand = new SqlCommand("SELECT * FROM CustomerTable where CustomerName='"
            + CustomerCode + "'",objConnection);

            DataSet objDataset = new DataSet();
            SqlDataAdapter objAdapter = new SqlDataAdapter(objCommand);
            objAdapter.Fill(objDataset);
            //bind the data to the UI

            //close connection
            objConnection.Close();
            return objDataset;

        }

        public bool DeleteCustomer(string strCustomerName)
        {
            string Connectionstring = ConfigurationManager.ConnectionStrings["DbConn"].ToString();
            SqlConnection objConnection = new SqlConnection(Connectionstring);
            objConnection.Open();

            //Fire command object
            SqlCommand objCommand = new SqlCommand("DELETE FROM CustomerTable where CustomerName='"
            + strCustomerName + "'",objConnection);

            objCommand.ExecuteNonQuery();
            //close connection
            objConnection.Close();
            return true;

        }

        public bool InsertCustomer(string strCustomerName,
          string Country,
          string Gender,
          string Hobbies,
          string Status)
        {

            string Connectionstring = ConfigurationManager.ConnectionStrings["DbConn"].ToString();
            SqlConnection objConnection = new SqlConnection(Connectionstring);
            objConnection.Open();
            try
            {
                string strInsertCommand = "INSERT INTO CustomerTable values('"
                    + strCustomerName + "','"
                    + Country + "' ,'"
                    + Gender + "','"
                    + Hobbies + "',"
                    + Status + ")";

                SqlCommand objCommand = new SqlCommand(strInsertCommand, objConnection);
                objCommand.ExecuteNonQuery();
                SqlDataAdapter objAdapter = new SqlDataAdapter(objCommand);
                //close connection

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                objConnection.Close();
            }
        }

        public bool UpdateCustomer(string strCustomerName,
           string Country,
           string Gender,
           string Hobbies,
           string Status)
        {
            string Connectionstring = ConfigurationManager.ConnectionStrings["DbConn"].ToString();
            SqlConnection objConnection = new SqlConnection(Connectionstring);
            objConnection.Open();
            //command fire SQL
            string strUpdateCommand = "UPDATE CustomerTable SET CustomerName= '" + strCustomerName + "',Country='" +
                   Country + "',Sex='"
                   + Hobbies + "',Hobbies='"
                   + Gender + "', Status ="
                   + Status + "WHERE CustomerName='" + strCustomerName + "'";

            SqlCommand objCommand = new SqlCommand(strUpdateCommand, objConnection);
            objCommand.ExecuteNonQuery();
            objConnection.Close();
            return true;
        }
    }
}