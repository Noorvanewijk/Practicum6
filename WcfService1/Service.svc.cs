using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WebService.Models;
using WebService.Services;

namespace WcfService1
{
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service : IService
    {
        internal TransactionService transactionService = new TransactionService();
        internal UserService userService = new UserService();
        internal ProductService productService = new ProductService();

        public List<ProductModel> GetAllProducts()
        {
            return productService.GetAllAvailibleProducts();
        }

        public ProductModel GetProductById(int id)
        {
            return productService.GetProductById(id);
        }

        public List<UserModel> GetAll()
        {
            return userService.GetAllUsers();
        }

        public UserModel GetUserById(int id)
        {
            return userService.GetUserById(id);
        }
        
        public UserModel RegisterUser(string username)
        {
            if (userService.UserExists(username))
            {
                return null;
            }

            return new UserModel(userService.CreateNewUser(username));
        }
        
        public List<TransactionModel> GetAllTransactions()
        {
            return transactionService.GetAllTransactions();
        }
        
        public TransactionModel GetTransactionById(int id)
        {
            return transactionService.GetTransactionById(id);
        }
        
        public TransactionModel CreateNewTransaction(int userId, List<Purchase> purchases)
        {
            return new TransactionModel(transactionService.CreateNewTransaction(userId, purchases));
        }
    }
}
