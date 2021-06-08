using CentuDY.Factories;
using CentuDY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Repositories
{
    public class TransactionRepository
    {
        private static DatabaseEntities db = new DatabaseEntities();
        public static HeaderTransaction insertHeader(int userId, DateTime transactionDate)
        {
            HeaderTransaction header = TransactionFactory.createHeader(userId, transactionDate);
            db.HeaderTransactions.Add(header);
            db.SaveChanges();

            return db.HeaderTransactions.OrderByDescending(x => x.TransactionId).First();
        }

        public static List<HeaderTransaction> getAllTransaction()
        {
            return db.HeaderTransactions.ToList();
        }

        public static int calculateGrandTotal(int transactionId)
        {
            return (from x in db.DetailTransactions
                    join y in db.Medicines
                    on x.MedicineId equals y.MedicineId where x.TransactionId == transactionId
                    select y.Price * x.Quantity).Sum();
        }

        public static int calculateGrandTotalUser(int userId)
        {
            return (from x in db.DetailTransactions
                    join y in db.Medicines
                    on x.MedicineId equals y.MedicineId
                    join z in db.HeaderTransactions
                    on x.TransactionId equals z.TransactionId
                    where z.UserId == userId
                    select y.Price * x.Quantity).Sum();
        }

        public static void insertDetail (int transactionId, int medicineId, int quantity)
        {
            DetailTransaction detail = TransactionFactory.createDetail(transactionId, medicineId, quantity);
            db.DetailTransactions.Add(detail);
            db.SaveChanges();
        }

        public static List<HeaderTransaction> getTransactionHistory(int userId)
        {
            return (from x in db.HeaderTransactions
                    where x.UserId == userId
                    select x).ToList();
        }

        public static List<ViewHistory> getAllHistory(int userId)
        {
            return (from x in db.HeaderTransactions
                    join y in db.DetailTransactions on x.TransactionId equals y.TransactionId
                    join z in db.Medicines on y.MedicineId equals z.MedicineId
                    where x.UserId== userId
                    select new ViewHistory
                    {
                        MedicineName = z.Name,
                        Quantity = y.Quantity,
                        TransactionDate = x.TransactionDate,
                        SubTotal = z.Price * y.Quantity,
                    }).ToList();
        }
    }
}