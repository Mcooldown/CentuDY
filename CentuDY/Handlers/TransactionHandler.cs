using CentuDY.Models;
using CentuDY.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Handlers
{
    public class TransactionHandler
    {
        public static bool checkoutTransaction(int userId)
        {
            List<Cart> carts = CartRepository.getAllCartProduct(userId);

            if (carts.Count == 0) return false;

            HeaderTransaction header = TransactionRepository.insertHeader(userId, DateTime.Today);

            foreach (Cart cart in carts)
            {
                TransactionRepository.insertDetail(header.TransactionId, cart.MedicineId, cart.Quantity);
                CartRepository.deleteCartProduct(cart.UserId, cart.MedicineId);
            }

            return true;
        }

        public static TransactionDataSet getTransactionDataSet()
        {
            List<HeaderTransaction> transactions = TransactionRepository.getAllTransaction();
            TransactionDataSet transactionDataSet = new TransactionDataSet();
            var headerTransaction = transactionDataSet.HeaderTransaction;
            var detailTransaction = transactionDataSet.DetailTransaction;
            foreach(var header in transactions)
            {
                var headerRow = headerTransaction.NewRow();
                headerRow["TransactionId"] = header.TransactionId;
                headerRow["Username"] = header.User.Username;
                headerRow["TransactionDate"] = header.TransactionDate;
                headerRow["GrandTotal"] = TransactionRepository.calculateGrandTotal(header.TransactionId);
                headerTransaction.Rows.Add(headerRow);
                foreach (var detail in header.DetailTransactions)
                {
                    var detailRow = detailTransaction.NewRow();
                    detailRow["TransactionId"] = detail.TransactionId;
                    detailRow["MedicineName"] = detail.Medicine.Name;
                    detailRow["MedicinePrice"] = detail.Medicine.Price;
                    detailRow["Quantity"] = detail.Quantity;
                    detailRow["SubTotal"] = detail.Quantity * detail.Medicine.Price;
                    detailTransaction.Rows.Add(detailRow);
                }
            }
            return transactionDataSet;
        }

        public static List<ViewHistory> getTransactionHistory(int userId)
        {
            return TransactionRepository.getAllHistory(userId);
        }

        public static int calculateGrandTotalUser(int userId)
        {
            return TransactionRepository.calculateGrandTotalUser(userId);
        }
    }
}