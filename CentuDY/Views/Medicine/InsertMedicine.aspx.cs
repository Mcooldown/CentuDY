using CentuDY.Controllers;
using CentuDY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CentuDY.Views.Medicine
{
    public partial class InsertMedicine : System.Web.UI.Page
    {
        public User user;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                user = AuthController.auth();
                if (user == null) Response.Redirect("~/Views/Login.aspx");
                if (!AuthController.isAdmin()) Response.Redirect("Home.aspx");
            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            String name = valName.Text.ToString();
            String description = valDescription.Text.ToString();
            String stock = valStock.Text.ToString();
            String price = valPrice.Text.ToString();

            String message = MedicineController.insertMedicine(name, description, stock, price);
            lblMessage.Text = message;

            if (message.Equals(""))
            {
                Response.Redirect("AdminViewMedicine.aspx");
            }
        }
    }
}