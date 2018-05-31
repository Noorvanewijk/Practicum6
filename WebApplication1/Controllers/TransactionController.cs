using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;
using WebService.Models;
using WebService.Services;

namespace WebService.Controllers
{
    public class TransactionController : Controller
    {
        internal TransactionService service = new TransactionService();

        public List<TransactionModel> GetAllTransactions()
        {
            return service.GetAllTransactions();
        }

        public TransactionModel GetTransactionById(int id)
        {
            return service.GetTransactionById(id);
        }

        public TransactionModel CreateNewTransaction(int userId, List<Purchase> purchases)
        {
            return new TransactionModel(service.CreateNewTransaction(userId, purchases));
        }
    }
}
