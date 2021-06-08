using CentuDY.Controllers;
using CentuDY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CentuDY.Views
{
    public partial class Home : System.Web.UI.Page
    {
        public User user;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                user = AuthController.auth();
                if (user == null) Response.Redirect("Login.aspx");
                lblUsername.Text = user.Username;
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            AuthController.logout();
            Response.Redirect("Login.aspx");
        }

        protected void btnProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("Profile/ViewProfile.aspx");
        }

        protected void btnCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cart/ViewCart.aspx");
        }

        protected void btnHistory_Click(object sender, EventArgs e)
        {
            Response.Redirect("Transaction/TransactionHistory.aspx");
        }

        protected void btnInsertMedicine_Click(object sender, EventArgs e)
        {
            Response.Redirect("Medicine/InsertMedicine.aspx");
        }

        protected void btnUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewUser.aspx");
        }

        protected void btnReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("Transaction/TransactionReport.aspx");
        }

        protected void btnAdminMedicine_Click(object sender, EventArgs e)
        {
            Response.Redirect("Medicine/AdminViewMedicine.aspx");
        }

        protected void btnMemberMedicine_Click(object sender, EventArgs e)
        {
            Response.Redirect("Medicine/MemberViewMedicine.aspx");
        }
    }
}