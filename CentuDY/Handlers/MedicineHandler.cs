using CentuDY.Models;
using CentuDY.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Handlers
{
    public class MedicineHandler
    {
        public static List<Medicine> getAllMedicine()
        {
            return MedicineRepository.getAllMedicine();
        }

        public static Medicine GetMedicineById(int id)
        {
            return MedicineRepository.getMedicineById(id);
        }

        public static void insertMedicine(String name, String description, int stock, int price)
        {
            Medicine existMedicine = MedicineRepository.getMedicineByName(name);

            if (existMedicine != null) 
            {
                MedicineRepository.updateMedicineStock(name, stock);
            }
            else
            {
                MedicineRepository.insertMedicine(name, description, stock, price);
            }
        }

        public static bool updateMedicine(int medicineId, String name, String description, int stock, int price)
        {
            Medicine medicine = MedicineRepository.getMedicineById(medicineId);

            if (medicine == null) return false;

             MedicineRepository.updateMedicine(medicineId, name, description, stock, price);
             return true;
         
        }

        public static bool deleteMedicine(int medicineId)
        {
            Medicine medicine = MedicineRepository.getMedicineById(medicineId);
            if (medicine == null) return false;

            MedicineRepository.deleteMedicine(medicineId);
            return true;
        }
    }
}