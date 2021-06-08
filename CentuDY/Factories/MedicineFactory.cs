using CentuDY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Factories
{
    public class MedicineFactory
    {
        public static Medicine createMedicine(String name, String description, int stock, int price)
        {
            return new Medicine
            {
                Name = name,
                Description = description,
                Stock = stock,
                Price = price,
            };
        }
    }
}