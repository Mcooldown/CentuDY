using CentuDY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Factories
{
    public class CartFactory
    {
        public static Cart createCartProduct(int userId, int medicineId, int quantity)
        {
            return new Cart
            {
                UserId = userId,
                MedicineId = medicineId,
                Quantity = quantity,
            };
        } 
    }
}