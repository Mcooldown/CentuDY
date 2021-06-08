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
    public partial class MemberViewMedicine : System.Web.UI.Page
    {
        public User user;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                user = AuthController.auth();
                if (user == null) Response.Redirect("~/Views/Login.aspx");
                if (!AuthController.isUser()) Response.Redirect("Home.aspx");
                getAllMedicine();
            }
        }

        private void getAllMedicine()
        {
            gvMedicine.DataSource = MedicineController.getAllMedicine();
            gvMedicine.DataBind();
        }

        protected void btnAddToCart_Click(object sender, EventArgs e)
        {
            var medicineId = (sender as Button).CommandArgument;
            Response.Redirect("~/Views/Cart/AddToCart.aspx?id=" + medicineId);
        }
    }
}