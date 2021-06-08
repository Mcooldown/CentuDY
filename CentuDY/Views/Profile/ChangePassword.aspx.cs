using CentuDY.Controllers;
using CentuDY.Models;
using CentuDY.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CentuDY.Views.Profile
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        public User user;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                user = AuthController.auth();
                if (user == null) Response.Redirect("~/Views/Login.aspx");
            }
        }

        protected void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            User currentUser = (User)Session["user"];
            String userId = currentUser.UserId.ToString();
            String oldPassword = valOldPassword.Text.ToString();
            String newPassword = valNewPassword.Text.ToString();
            String confirmPassword = valConfirmPassword.Text.ToString();
            String message = UserController.changePassword(userId, oldPassword, newPassword, confirmPassword);
            lblMessage.Text = message;
            if (message.Equals(""))
            {
                Response.Redirect("ViewProfile.aspx");
            }

        }
    }
}