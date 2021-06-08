using CentuDY.Handlers;
using CentuDY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentuDY.Controllers
{
    public class TransactionController
    {
        public static String checkoutTransaction(int userId)
        {
            String message;

            bool inserted = TransactionHandler.checkoutTransaction(userId);

            if (inserted) message = "";
            else message = "Checkout failed, no items in cart";
            return message;
        }

        public static TransactionDataSet getTransactionDataSet()
        {
            return TransactionHandler.getTransactionDataSet();
        }

        public static List<ViewHistory> getTransactionHistory(int userId)
        {
            return TransactionHandler.getTransactionHistory(userId);
        }

        public static int calculateGrandTotalUser(int userId)
        {
            return TransactionHandler.calculateGrandTotalUser(userId);
        }
    }
}