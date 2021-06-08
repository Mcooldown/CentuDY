using CentuDY.Models;
using CentuDY.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Handlers
{
    public class CartHandler
    {
        public static List<ViewCart> getAllCartProduct(int userId)
        {
            return CartRepository.GetViewCarts(userId);
        }

        public static void insertCartProduct(int userId, int medicineId, int quantity)
        {
            Cart product = CartRepository.getCartProductById(userId, medicineId);

            if (product == null) CartRepository.insertProductToCart(userId, medicineId, quantity);
            else CartRepository.updateQuantityCartProduct(userId, medicineId, quantity);
        }

        public static int getCartProductSum(int medicineId)
        {
            return CartRepository.getCartProductSum(medicineId);
        }

        public static bool deleteCartProduct(int userId, int medicineId)
        {
            Cart product = CartRepository.getCartProductById(userId, medicineId);

            if (product == null) return false;

            CartRepository.deleteCartProduct(userId, medicineId);
            return true;
        }

        public static int calculateGrandTotalCart(int userId)
        {
            return CartRepository.calculateGrandTotalCart(userId);
        }
    }
}