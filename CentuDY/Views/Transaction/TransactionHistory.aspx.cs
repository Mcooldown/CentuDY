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
    public partial class TransactionHistory : System.Web.UI.Page
    {
        User user;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                user = AuthController.auth();
                if (user == null) Response.Redirect("~/Views/Login.aspx");
                if (!AuthController.isUser()) Response.Redirect("Home.aspx");
                getTransactionHistory();
            }
        }

        private void getTransactionHistory()
        {
            User userNow = (User)Session["user"];
            gvTransactionHistory.DataSource = TransactionController.getTransactionHistory(userNow.UserId);
            gvTransactionHistory.DataBind();
            lblGrandTotal.Text = "Grand Total =" + TransactionController.calculateGrandTotalUser(userNow.UserId).ToString();
        }

        

    }
}