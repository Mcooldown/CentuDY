using CentuDY.Controllers;
using CentuDY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CentuDY.Views.Transaction
{
    public partial class TransactionReport : System.Web.UI.Page
    {
        public User user;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                user = AuthController.auth();
                if (user == null) Response.Redirect("~/Views/Login.aspx");
                if (!AuthController.isAdmin()) Response.Redirect("Home.aspx");
                getTransactionReport();
            }
        }

        private void getTransactionReport()
        {
            TransactionCrystalReport transactionCrystalReport = new TransactionCrystalReport();
            TransactionDataSet transactionDataSet = TransactionController.getTransactionDataSet();
            transactionCrystalReport.SetDataSource(transactionDataSet);
            crvReport.ReportSource = transactionCrystalReport;
        }
    }
}