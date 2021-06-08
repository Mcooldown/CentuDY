using CentuDY.Controllers;
using CentuDY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CentuDY.Views.Profile
{
    public partial class ViewProfile : System.Web.UI.Page
    {
        public User user;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                user = AuthController.auth();
                if (user == null) Response.Redirect("~/Views/Login.aspx");
                showProfile(user.UserId);
            }
        }

        private void showProfile(int id)
        {
            User currentUser = UserController.getUserById(id);
            lblUsername.Text = currentUser.Username.ToString();
            lblName.Text = currentUser.Name.ToString();
            lblGender.Text = currentUser.Gender.ToString();
            lblPhoneNumber.Text = currentUser.PhoneNumber.ToString();
            lblAddress.Text = currentUser.Address.ToString();
        }

        protected void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateProfile.aspx");
        }


        protected void btnChangePassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("ChangePassword.aspx");
        }
    }
}