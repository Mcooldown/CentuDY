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
    public partial class Login : System.Web.UI.Page
    {
        public User user;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                user = AuthController.auth();
                if (user != null) Response.Redirect("Home.aspx");
                else
                {
                    if (AuthController.userFromCookie() != null) {
                        User user = AuthController.userFromCookie();
                        valUsername.Text = user.Username;
                        valPassword.Text = user.Password;
                    }
                }
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            String username = valUsername.Text.ToString();
            String password = valPassword.Text.ToString();

            String message = AuthController.login(username, password, cbCookie.Checked);

            if (message.Equals("")) Response.Redirect("Home.aspx");
            else lblMessage.Text = "Invalid username or password";
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}