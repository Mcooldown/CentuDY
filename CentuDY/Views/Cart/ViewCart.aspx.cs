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
    public partial class ViewCart : System.Web.UI.Page
    {
        public User user;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                user = AuthController.auth();
                if (user == null) Response.Redirect("~/Views/Login.aspx");
                if (!AuthController.isUser()) Response.Redirect("Home.aspx");
                getAllCartProduct();
            }

        }

        private void getAllCartProduct()
        {
            User userNow = (User)Session["user"];
            if(CartController.getAllCartProduct(userNow.UserId).Count > 0)
            {
                gvCart.DataSource = CartController.getAllCartProduct(userNow.UserId);
                gvCart.DataBind();
                lblGrandTotal.Text = "Grand Total =" + CartController.calculateGrandTotalCart(userNow.UserId).ToString();
            }
            else
            {
                lblGrandTotal.Text = "No Item";
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            var medicineId = (sender as Button).CommandArgument;
            User userNow = (User)Session["user"];
            int userId = userNow.UserId;

            String message = CartController.deleteCartProduct(userId,Int32.Parse(medicineId));
            if (message.Equals("")) getAllCartProduct();
            else lblMessage.Text = message;

        }

        protected void btnCheckout_Click(object sender, EventArgs e)
        {
            User userNow = (User)Session["user"];
            int userId = userNow.UserId;
            String message = TransactionController.checkoutTransaction(userId);
            
            if (message.Equals("")) Response.Redirect("~/Views/Home.aspx");
            else lblMessage.Text = message;

        }
    }
}