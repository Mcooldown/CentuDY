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
    public partial class UpdateMedicine : System.Web.UI.Page
    {
        public User user;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                user = AuthController.auth();
                if (user == null) Response.Redirect("~/Views/Login.aspx");
                if (!AuthController.isAdmin()) Response.Redirect("Home.aspx");

                if (Request.QueryString["id"] != null)
                {
                    var medicineId = Request.QueryString["id"];
                    var medicine = MedicineController.GetMedicineById(Int32.Parse(medicineId));

                    valName.Text = medicine.Name;
                    valDescription.Text = medicine.Description;
                    valPrice.Text = medicine.Price.ToString();
                    valStock.Text = medicine.Stock.ToString();
                }
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            var medicineId = Request.QueryString["id"];
            String name = valName.Text.ToString();
            String description = valDescription.Text.ToString();
            String price = valPrice.Text.ToString();
            String stock = valStock.Text.ToString();

            String message = MedicineController.updateMedicine(medicineId, name, description, stock, price);

            if (message.Equals(""))
            {
                Response.Redirect("AdminViewMedicine.aspx");
            }
            lblMessage.Text = message;
        }
    }
}