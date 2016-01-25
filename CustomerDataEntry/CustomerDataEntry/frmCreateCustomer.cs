using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using DataAccess;

namespace CustomerDataEntry
{
    public partial class frmCustomerDataEntry : Form
    {
        public frmCustomerDataEntry()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string gender = "";
            string hobbies = "";
            string status ="";

            if (rdoMale.Checked)
            {
                gender= "Male";
            }
            else
            {
                gender ="Female";
            }

            if (chkReading.Checked)
            {
                hobbies ="Reading";
            }
            else
            {
                hobbies = "Sports";
            }

            if(rdoMarried.Checked)
            {
                status="1";
            }
            else
            {
                status="0";
            }

            clsSqlServer objInsert = new clsSqlServer();
            objInsert.InsertCustomer(txtCustomerName.Text,
                cboCountry.Text,
                gender,
                hobbies,
                status);
            
            ClearData();
            LoadCustomers();
          
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            clsSqlServer obj = new clsSqlServer();
            obj.DeleteCustomer(txtCustomerName.Text);
            LoadCustomers();
        }

        private void frmCustomerDataEntry_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            clsSqlServer obj = new clsSqlServer();
            DataSet objDataset = obj.getCustomers();
            //bind the data to the UI
            dtgCustomers.DataSource = objDataset.Tables[0];

            
        }

        private void dtgCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //In this section will get the customer code which is selected
            string strSelectedCustomer = dtgCustomers.Rows[e.RowIndex].Cells[0].Value.ToString();
            //e.rows gets the selected row
            //zero the cell gets the customer code
            DisplayCustomer(strSelectedCustomer);
        }

        private void DisplayCustomer(string CustomerCode)
        {

            clsSqlServer obj = new clsSqlServer();
            DataSet objDataset = obj.getCustomers(CustomerCode);


            //Select the records and display it on the screen
            string strCustomerName = objDataset.Tables[0].Rows[0][0].ToString();
            string strCountryName = objDataset.Tables[0].Rows[0][1].ToString();
            string strgender = objDataset.Tables[0].Rows[0][2].ToString();
            string strhobbies = objDataset.Tables[0].Rows[0][3].ToString();

            bool Married = false;
            if (objDataset.Tables[0].Rows[0][4] != DBNull.Value)
            {
                Married = Convert.ToBoolean(objDataset.Tables[0].Rows[0][4]);
            }


            txtCustomerName.Text = strCustomerName;
            cboCountry.Text = strCountryName;

            if ((strgender.Length == 0) || (strgender == "Male"))
            {
                rdoMale.Checked = true;
            }
            else
            {
                rdoFemale.Checked = true;
            }

            //hoobies boolean

            if ((strhobbies.Length == 0) || (strgender == "Sports"))
            {
                chkReading.Checked = true;
            }
            else
            {
                chkSports.Checked = true;
            }

            //status boolean


            if (Married)
            {
                rdoMarried.Checked = true;
            }
            else
            {
                rdoUnmarried.Checked = true;
            }

        }

        private void ClearData()
        {
            txtCustomerName.Text = "";
            cboCountry.SelectedIndex = 0;
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            rdoMarried.Checked = false;
            rdoUnmarried.Checked = false;
            chkReading.Checked = false;
            chkSports.Checked = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //UPDATING edited records.
           
            //COMMAND INSERT FIRE
            string gender = "";
            string hobbies = "";
            string status = "";

            if (rdoMale.Checked)
            {
                 gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            if (chkReading.Checked)
            {
                hobbies = "Reading";
            }
            else
            {
                hobbies = "Sports";
            }

            if (rdoMarried.Checked)
            {
                status = "1";
            }
            else
            {
                status = "0";
            }

            clsSqlServer objUpdate = new clsSqlServer();
            objUpdate.UpdateCustomer(txtCustomerName.Text,
                cboCountry.Text,
                gender,
                hobbies,
                status);

            ClearData();
            LoadCustomers();
        }

        private void dtgCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



    }
}
