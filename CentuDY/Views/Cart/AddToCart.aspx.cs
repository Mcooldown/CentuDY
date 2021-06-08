using CentuDY.Controllers;
using CentuDY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CentuDY.Views.Cart
{
    public partial class AddToCart : System.Web.UI.Page
    {
        public User user;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                user = AuthController.auth();
                if (user == null) Response.Redirect("~/Views/Login.aspx");
                if (!AuthController.isUser()) Response.Redirect("Home.aspx");
                getMedicineData();
            }
        }

        private void getMedicineData()
        {
            if (Request.QueryString["id"] != null)
            {
                var medicineId = Request.QueryString["id"];
                var medicine = MedicineController.GetMedicineById(Int32.Parse(medicineId));

                lblName.Text = medicine.Name;
                lblDescription.Text = medicine.Description;
                lblPrice.Text = medicine.Price.ToString();
                lblStock.Text = medicine.Stock.ToString();
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            var medicineId = Request.QueryString["id"];
            User userNow = (User)Session["user"];
            int userId = userNow.UserId;
            String quantity = valQuantity.Text.ToString();

            String message = CartController.addProductToCart(userId, Int32.Parse(medicineId), quantity);

            if (message.Equals("")) Response.Redirect("ViewCart.aspx");
            else lblMessage.Text = message;
        }
    }
}