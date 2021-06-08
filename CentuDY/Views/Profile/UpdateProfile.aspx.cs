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
    public partial class UpdateProfile : System.Web.UI.Page
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
            valName.Text = currentUser.Name.ToString();

            if (currentUser.Gender.ToString().Equals("Male"))
            {
                valGenderMale.Checked = true;
            }
            else
            {
                valGenderFemale.Checked = true;
            }
            valPhoneNumber.Text = currentUser.PhoneNumber.ToString();
            valAddress.Text = currentUser.Address.ToString();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            User currentUser = (User)Session["user"];
            String userId = currentUser.UserId.ToString();
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

            String message = UserController.updateProfile(userId, name, gender, phoneNumber, address);
            lblMessage.Text = message;

            if (message.Equals(""))
            {
                Response.Redirect("ViewProfile.aspx");
            }
        }
    }
}