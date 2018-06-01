﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Practicum6.SOAPService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductModel", Namespace="http://schemas.datacontract.org/2004/07/WebService.Models")]
    [System.SerializableAttribute()]
    public partial class ProductModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CurrentStockField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PriceField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CurrentStock {
            get {
                return this.CurrentStockField;
            }
            set {
                if ((this.CurrentStockField.Equals(value) != true)) {
                    this.CurrentStockField = value;
                    this.RaisePropertyChanged("CurrentStock");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserModel", Namespace="http://schemas.datacontract.org/2004/07/WebService.Models")]
    [System.SerializableAttribute()]
    public partial class UserModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal FundsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Funds {
            get {
                return this.FundsField;
            }
            set {
                if ((this.FundsField.Equals(value) != true)) {
                    this.FundsField = value;
                    this.RaisePropertyChanged("Funds");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TransactionModel", Namespace="http://schemas.datacontract.org/2004/07/WebService.Models")]
    [System.SerializableAttribute()]
    public partial class TransactionModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Practicum6.SOAPService.UserModel BuyerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Practicum6.SOAPService.TransactionRowModel[] PurchasedProductsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal TotalPriceField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Practicum6.SOAPService.UserModel Buyer {
            get {
                return this.BuyerField;
            }
            set {
                if ((object.ReferenceEquals(this.BuyerField, value) != true)) {
                    this.BuyerField = value;
                    this.RaisePropertyChanged("Buyer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Practicum6.SOAPService.TransactionRowModel[] PurchasedProducts {
            get {
                return this.PurchasedProductsField;
            }
            set {
                if ((object.ReferenceEquals(this.PurchasedProductsField, value) != true)) {
                    this.PurchasedProductsField = value;
                    this.RaisePropertyChanged("PurchasedProducts");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal TotalPrice {
            get {
                return this.TotalPriceField;
            }
            set {
                if ((this.TotalPriceField.Equals(value) != true)) {
                    this.TotalPriceField = value;
                    this.RaisePropertyChanged("TotalPrice");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TransactionRowModel", Namespace="http://schemas.datacontract.org/2004/07/WebService.Models")]
    [System.SerializableAttribute()]
    public partial class TransactionRowModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AmountPurchasedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal TotalPriceField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int AmountPurchased {
            get {
                return this.AmountPurchasedField;
            }
            set {
                if ((this.AmountPurchasedField.Equals(value) != true)) {
                    this.AmountPurchasedField = value;
                    this.RaisePropertyChanged("AmountPurchased");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductName {
            get {
                return this.ProductNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductNameField, value) != true)) {
                    this.ProductNameField = value;
                    this.RaisePropertyChanged("ProductName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal TotalPrice {
            get {
                return this.TotalPriceField;
            }
            set {
                if ((this.TotalPriceField.Equals(value) != true)) {
                    this.TotalPriceField = value;
                    this.RaisePropertyChanged("TotalPrice");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Purchase", Namespace="http://schemas.datacontract.org/2004/07/WebService.Models")]
    [System.SerializableAttribute()]
    public partial class Purchase : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProductIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal TotalPriceField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Amount {
            get {
                return this.AmountField;
            }
            set {
                if ((this.AmountField.Equals(value) != true)) {
                    this.AmountField = value;
                    this.RaisePropertyChanged("Amount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProductId {
            get {
                return this.ProductIdField;
            }
            set {
                if ((this.ProductIdField.Equals(value) != true)) {
                    this.ProductIdField = value;
                    this.RaisePropertyChanged("ProductId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal TotalPrice {
            get {
                return this.TotalPriceField;
            }
            set {
                if ((this.TotalPriceField.Equals(value) != true)) {
                    this.TotalPriceField = value;
                    this.RaisePropertyChanged("TotalPrice");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SOAPService.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllProducts", ReplyAction="http://tempuri.org/IService/GetAllProductsResponse")]
        Practicum6.SOAPService.ProductModel[] GetAllProducts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllProducts", ReplyAction="http://tempuri.org/IService/GetAllProductsResponse")]
        System.Threading.Tasks.Task<Practicum6.SOAPService.ProductModel[]> GetAllProductsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetProductById", ReplyAction="http://tempuri.org/IService/GetProductByIdResponse")]
        Practicum6.SOAPService.ProductModel GetProductById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetProductById", ReplyAction="http://tempuri.org/IService/GetProductByIdResponse")]
        System.Threading.Tasks.Task<Practicum6.SOAPService.ProductModel> GetProductByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAll", ReplyAction="http://tempuri.org/IService/GetAllResponse")]
        Practicum6.SOAPService.UserModel[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAll", ReplyAction="http://tempuri.org/IService/GetAllResponse")]
        System.Threading.Tasks.Task<Practicum6.SOAPService.UserModel[]> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetUserById", ReplyAction="http://tempuri.org/IService/GetUserByIdResponse")]
        Practicum6.SOAPService.UserModel GetUserById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetUserById", ReplyAction="http://tempuri.org/IService/GetUserByIdResponse")]
        System.Threading.Tasks.Task<Practicum6.SOAPService.UserModel> GetUserByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/RegisterUser", ReplyAction="http://tempuri.org/IService/RegisterUserResponse")]
        Practicum6.SOAPService.UserModel RegisterUser(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/RegisterUser", ReplyAction="http://tempuri.org/IService/RegisterUserResponse")]
        System.Threading.Tasks.Task<Practicum6.SOAPService.UserModel> RegisterUserAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/LoginUser", ReplyAction="http://tempuri.org/IService/LoginUserResponse")]
        Practicum6.SOAPService.UserModel LoginUser(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/LoginUser", ReplyAction="http://tempuri.org/IService/LoginUserResponse")]
        System.Threading.Tasks.Task<Practicum6.SOAPService.UserModel> LoginUserAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllTransactions", ReplyAction="http://tempuri.org/IService/GetAllTransactionsResponse")]
        Practicum6.SOAPService.TransactionModel[] GetAllTransactions();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllTransactions", ReplyAction="http://tempuri.org/IService/GetAllTransactionsResponse")]
        System.Threading.Tasks.Task<Practicum6.SOAPService.TransactionModel[]> GetAllTransactionsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetTransactionById", ReplyAction="http://tempuri.org/IService/GetTransactionByIdResponse")]
        Practicum6.SOAPService.TransactionModel GetTransactionById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetTransactionById", ReplyAction="http://tempuri.org/IService/GetTransactionByIdResponse")]
        System.Threading.Tasks.Task<Practicum6.SOAPService.TransactionModel> GetTransactionByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CreateNewTransaction", ReplyAction="http://tempuri.org/IService/CreateNewTransactionResponse")]
        Practicum6.SOAPService.TransactionModel CreateNewTransaction(int userId, Practicum6.SOAPService.Purchase[] purchases);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CreateNewTransaction", ReplyAction="http://tempuri.org/IService/CreateNewTransactionResponse")]
        System.Threading.Tasks.Task<Practicum6.SOAPService.TransactionModel> CreateNewTransactionAsync(int userId, Practicum6.SOAPService.Purchase[] purchases);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : Practicum6.SOAPService.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<Practicum6.SOAPService.IService>, Practicum6.SOAPService.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Practicum6.SOAPService.ProductModel[] GetAllProducts() {
            return base.Channel.GetAllProducts();
        }
        
        public System.Threading.Tasks.Task<Practicum6.SOAPService.ProductModel[]> GetAllProductsAsync() {
            return base.Channel.GetAllProductsAsync();
        }
        
        public Practicum6.SOAPService.ProductModel GetProductById(int id) {
            return base.Channel.GetProductById(id);
        }
        
        public System.Threading.Tasks.Task<Practicum6.SOAPService.ProductModel> GetProductByIdAsync(int id) {
            return base.Channel.GetProductByIdAsync(id);
        }
        
        public Practicum6.SOAPService.UserModel[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<Practicum6.SOAPService.UserModel[]> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public Practicum6.SOAPService.UserModel GetUserById(int id) {
            return base.Channel.GetUserById(id);
        }
        
        public System.Threading.Tasks.Task<Practicum6.SOAPService.UserModel> GetUserByIdAsync(int id) {
            return base.Channel.GetUserByIdAsync(id);
        }
        
        public Practicum6.SOAPService.UserModel RegisterUser(string username) {
            return base.Channel.RegisterUser(username);
        }
        
        public System.Threading.Tasks.Task<Practicum6.SOAPService.UserModel> RegisterUserAsync(string username) {
            return base.Channel.RegisterUserAsync(username);
        }
        
        public Practicum6.SOAPService.UserModel LoginUser(string username, string password) {
            return base.Channel.LoginUser(username, password);
        }
        
        public System.Threading.Tasks.Task<Practicum6.SOAPService.UserModel> LoginUserAsync(string username, string password) {
            return base.Channel.LoginUserAsync(username, password);
        }
        
        public Practicum6.SOAPService.TransactionModel[] GetAllTransactions() {
            return base.Channel.GetAllTransactions();
        }
        
        public System.Threading.Tasks.Task<Practicum6.SOAPService.TransactionModel[]> GetAllTransactionsAsync() {
            return base.Channel.GetAllTransactionsAsync();
        }
        
        public Practicum6.SOAPService.TransactionModel GetTransactionById(int id) {
            return base.Channel.GetTransactionById(id);
        }
        
        public System.Threading.Tasks.Task<Practicum6.SOAPService.TransactionModel> GetTransactionByIdAsync(int id) {
            return base.Channel.GetTransactionByIdAsync(id);
        }
        
        public Practicum6.SOAPService.TransactionModel CreateNewTransaction(int userId, Practicum6.SOAPService.Purchase[] purchases) {
            return base.Channel.CreateNewTransaction(userId, purchases);
        }
        
        public System.Threading.Tasks.Task<Practicum6.SOAPService.TransactionModel> CreateNewTransactionAsync(int userId, Practicum6.SOAPService.Purchase[] purchases) {
            return base.Channel.CreateNewTransactionAsync(userId, purchases);
        }
    }
}
