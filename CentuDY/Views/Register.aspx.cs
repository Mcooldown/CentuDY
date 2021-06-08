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
    public partial class Register : System.Web.UI.Page
    {
        public User user;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                user = AuthController.auth();
                if (user != null)Response.Redirect("Home.aspx");
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            String username = valUsername.Text.ToString();
            String password = valPassword.Text.ToString();
            String confirmPassword = valConfirmPassword.Text.ToString();
            String name = valName.Text.ToString();

            String gender;
            if (valGenderMale.Checked)
            {
                gender = valGenderMale.Text.ToString();
            }
            else if (valGenderFemale.Checked)
            {
                gender = valGenderFemale.Text.ToString();
            }
            else
            {
                gender = "";
            }

            String phoneNumber = valPhoneNumber.Text.ToString();
            String address = valAddress.Text.ToString();

            String message = UserController.insertUser(username, password, confirmPassword, name, gender, phoneNumber, address);
            lblMessage.Text = message;

            if (message.Equals(""))
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}