using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using WebApplication1;

namespace WebService.Models
{
    [DataContract]
    public class UserModel
    {
        [DataMember]
        public int Id { get; private set; }
        [DataMember]
        public string Username { get; private set; }
        [DataMember]
        public string Password { get; private set; }
        [DataMember]
        public decimal Funds { get; private set; }

        public UserModel(User u)
        {
            this.Id = u.Id;
            this.Username = u.Username;
            this.Password = u.Password;
            this.Funds = u.Funds;
        }
    }
}