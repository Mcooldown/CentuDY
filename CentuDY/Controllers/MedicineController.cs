using CentuDY.Handlers;
using CentuDY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Controllers
{
    public class MedicineController
    {
        public static List<Medicine> getAllMedicine()
        {
            return MedicineHandler.getAllMedicine();
        }

        public static Medicine GetMedicineById(int id)
        {
            return MedicineHandler.GetMedicineById(id);
        }

        public static string validateMedicine(String name, String description, String stock, String price)
        {
            String message;
            int priceParse, stockParse;

            if (name.Equals(""))
            {
                message = "name cannot be empty";
            }
            else if (description.Equals(""))
            {
                message = "description cannot be empty";
            }
            else if (description.Length <= 10)
            {
                message = "description must be longer than 10 characters";
            }
            else if (stock.Equals(""))
            {
                message = "stock cannot be empty";
            }
            else if(!Int32.TryParse(stock, out stockParse))
            {
                message = "stock must be a number";
            }
            else if(stockParse <= 0)
            {
                message = "stock must greater than 0";
            }
            else if (price.Equals(""))
            {
                message = "price cannot be empty";
            }
            else if (!Int32.TryParse(price, out priceParse))
            {
                message = "price must be a number";
            }
            else if (priceParse <= 0)
            {
                message = "price must greater than 0";
            }
            else
            {
                message = "";
                MedicineHandler.insertMedicine(name, description, stockParse, priceParse);
            }

            return message;
        }

        public static String insertMedicine(String name, String description, String stock, String price)
        {
            String message = validateMedicine(name, description, stock, price);
            if (message.Equals(""))
            {
                MedicineHandler.insertMedicine(name, description, Int32.Parse(stock), Int32.Parse(price));
            }
            return message;
        }

        public static String updateMedicine(String medicineId, String name, String description, String stock, String price)
        {
            String message = validateMedicine(name, description, stock, price);
            if (message.Equals(""))
            {
                MedicineHandler.updateMedicine(Int32.Parse(medicineId), name, description, Int32.Parse(stock), Int32.Parse(price));
            }
            return message;
        }

        public static bool deleteMedicine(String medicineId)
        {
            return MedicineHandler.deleteMedicine(Int32.Parse(medicineId));
        }
    }
}