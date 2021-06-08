using CentuDY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Factories
{
    public class TransactionFactory
    {
        public static HeaderTransaction createHeader(int userId, DateTime transactionDate)
        {
            return new HeaderTransaction {
                UserId = userId,
                TransactionDate = transactionDate.ToString(),
            };
        }

        public static DetailTransaction createDetail(int transactionId, int medicineId, int quantity)
        {
            return new DetailTransaction
            {
                TransactionId = transactionId,
                MedicineId = medicineId,
                Quantity = quantity,
            };
        }
    }
}