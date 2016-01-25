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
    public partial class frmSearchCustomer : Form
    {
        public frmSearchCustomer()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            clsSqlServer objSql = new clsSqlServer();
            DataSet objDataset = objSql.getCustomers();
            datagridSearch.DataSource = objDataset.Tables[0];
        }

        private void datagridSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
