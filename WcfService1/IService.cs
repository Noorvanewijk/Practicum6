using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WebService.Models;
using WebService.Services;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        [WebGet]
        List<ProductModel> GetAllProducts();

        [OperationContract]
        [WebGet]
        ProductModel GetProductById(int id);

        [OperationContract]
        [WebGet]
        List<UserModel> GetAll();

        [OperationContract]
        [WebGet]
        UserModel GetUserById(int id);

        [OperationContract]
        [WebInvoke]
        UserModel RegisterUser(string username);

        [OperationContract]
        [WebGet]
        UserModel LoginUser(string username, string password);

        [OperationContract]
        [WebGet]
        List<TransactionModel> GetAllTransactions();

        [OperationContract]
        [WebGet]
        TransactionModel GetTransactionById(int id);

        [OperationContract]
        [WebInvoke]
        TransactionModel CreateNewTransaction(int userId, List<int> productIds, List<int> productAmounts);
    }
}
