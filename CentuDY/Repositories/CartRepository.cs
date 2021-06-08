using CentuDY.Factories;
using CentuDY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Repositories
{
    public class CartRepository
    {
        public static DatabaseEntities db = new DatabaseEntities();
        public static List<Cart> getAllCartProduct(int userId)
        {
            return (from x in db.Carts
                    where x.UserId == userId
                    select x).ToList();
        }

        public static List<ViewCart> GetViewCarts(int userId)
        {
            return (from x in db.Carts
                    join y in db.Medicines
                    on x.MedicineId equals y.MedicineId
                    where x.UserId == userId
                    select new ViewCart
                    {
                        MedicineId = y.MedicineId,
                        MedicineName = y.Name,
                        Price = y.Price,
                        Quantity = x.Quantity,
                        SubTotal = y.Price * x.Quantity,
                    }).ToList();
        }

        public static void insertProductToCart(int userId, int medicineId, int quantity)
        {
            Cart newProduct = CartFactory.createCartProduct(userId, medicineId, quantity);
            db.Carts.Add(newProduct);
            db.SaveChanges();
        }

        public static Cart getCartProductById(int userId, int medicineId)
        {
            return (from x in db.Carts where x.UserId == userId && x.MedicineId == medicineId select x).FirstOrDefault();
        }

        public static int getCartProductSum(int medicineId)
        {
            return (from x in db.Carts where x.MedicineId == medicineId select x).Sum(x => (int?)x.Quantity) ?? 0;
        }

        public static void updateQuantityCartProduct(int userId, int medicineId, int quantity)
        {
            Cart product = getCartProductById(userId, medicineId);
            product.Quantity += quantity;
            db.SaveChanges();
        }

        public static void deleteCartProduct(int userId, int medicineId)
        {
            Cart product = getCartProductById(userId, medicineId);
            db.Carts.Remove(product);
            db.SaveChanges();
        }

        public static int calculateGrandTotalCart(int userId)
        {
            return (from x in db.Carts
                    join y in db.Medicines
                    on x.MedicineId equals y.MedicineId
                    where x.UserId == userId
                    select y.Price * x.Quantity).Sum();
        }

    }
}