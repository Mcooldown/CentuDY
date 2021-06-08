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
    public partial class ViewUser : System.Web.UI.Page
    {
        public User user;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                user = AuthController.auth();
                if (user == null) Response.Redirect("Login.aspx");
                if (!AuthController.isAdmin()) Response.Redirect("Home.aspx");
                getAllUser();
            }

        }

        private void getAllUser()
        {
            gvUser.DataSource = UserController.getAllUser();
            gvUser.DataBind();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            var userId = (sender as Button).CommandArgument;
            bool isDeleted = UserController.deleteUser(userId);
            getAllUser();
        }
    }
}