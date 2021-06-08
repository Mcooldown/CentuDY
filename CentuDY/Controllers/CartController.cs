using CentuDY.Handlers;
using CentuDY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Controllers
{
    public class CartController
    {
        public static List<ViewCart> getAllCartProduct(int userId)
        {
            return CartHandler.getAllCartProduct(userId);
        }

        public static String addProductToCart(int userId, int medicineId, String quantity)
        {
            String message;
            int quantityParse;
            if (quantity.Equals(""))
            {
                message = "quantity cannot be empty";
            }
            else if (!Int32.TryParse(quantity, out quantityParse))
            {
                message = "quantity must be a number";
            }
            else if (quantityParse <= 0)
            {
                message = "quantity must greater than 0";
            }
            else
            {
                Medicine medicine = MedicineHandler.GetMedicineById(medicineId);
                int sumCartProduct = CartHandler.getCartProductSum(medicineId);

                if (medicine.Stock < quantityParse) message = "Must be less than or equals to current stock";
                else if (sumCartProduct + quantityParse > medicine.Stock) message = "The inputted quantity and the reserved quantity in other carts combined altogether must not exceed the selected medicine’s current stock.";
                else
                {
                    CartHandler.insertCartProduct(userId, medicineId, quantityParse);
                    message = "";
                }
            }
            return message;
        }

        public static String deleteCartProduct(int userId, int medicineId)
        {
            String message;
            bool isDeleted = CartHandler.deleteCartProduct(userId,medicineId);

            if (isDeleted) message = "";
            else message = "delete fail";

            return message;
        }

        public static int calculateGrandTotalCart(int userId)
        {
            return CartHandler.calculateGrandTotalCart(userId);
        }
    }
}