using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebService.Models
{
    [DataContract]
    public class UserModel
    {
        [DataMember]
        private int id;
        [DataMember]
        private string username;
        [DataMember]
        private string password;

        public UserModel(User u)
        {
            this.id = u.Id;
            this.username = u.Username;
            this.password = u.Password;
        }
    }
}