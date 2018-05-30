using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService.Models;

namespace WebService.Services
{
    public class UserService
    {
        public List<UserModel> GetAllUsers()
        {
            using (var context = new dbEntities())
            {
                var result = new List<UserModel>();
                (from x in context.Users select x).ToList().ForEach(x => result.Add(new UserModel(x)));
                return result;
            }
        }
    }
}