using CentuDY.Factories;
using CentuDY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Repositories
{
    public class MedicineRepository
    {
        public static DatabaseEntities db = new DatabaseEntities();

        public static List<Medicine> getAllMedicine()
        {
            return db.Medicines.ToList();
        }

        public static void insertMedicine(String name, String description, int stock, int price)
        {
            Medicine medicine = MedicineFactory.createMedicine(name, description, stock, price);
            db.Medicines.Add(medicine);
            db.SaveChanges();
        }

        public static Medicine getMedicineByName(String name)
        {
            return (from x in db.Medicines where x.Name == name select x).FirstOrDefault();
        }

        public static Medicine getMedicineById(int id)
        {
            return (from x in db.Medicines where x.MedicineId == id select x).FirstOrDefault();
        }

        public static void updateMedicineStock(String name, int stock)
        {
            Medicine medicine = getMedicineByName(name);
            medicine.Stock += stock;
            db.SaveChanges();
        }

        public static void updateMedicine(int medicineId, String name, String description, int stock, int price)
        {
            Medicine medicine = getMedicineById(medicineId);
            medicine.Name = name;
            medicine.Description = description;
            medicine.Stock = stock;
            medicine.Price = price;
            db.SaveChanges();
        }

        public static void deleteMedicine(int medicineId)
        {
            Medicine medicine = getMedicineById(medicineId);
            db.Medicines.Remove(medicine);
            db.SaveChanges();
        }
    }
}