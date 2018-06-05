using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService;
using WebService.Models;

namespace WebService.Services
{
    public class UserService
    {
        public List<UserModel> GetAllUsers()
        {
            using (var context = new databaseEntities())
            {
                var result = new List<UserModel>();
                (from x in context.Users select x).ToList().ForEach(x => result.Add(new UserModel(x)));
                return result;
            }
        }

        public UserModel GetUserById(int id)
        {
            try
            {
                using (var context = new databaseEntities())
                {
                    return new UserModel((from x in context.Users where x.Id == id select x).First());
                }
            }
            catch
            {
                return null;
            }
        }

        public User CreateNewUser(string username)
        {
            using (var context = new databaseEntities())
            {
                var u = new User { Username = username, Password = new string(username.ToCharArray().Reverse().ToArray()), Funds = 100 };
                context.Users.Add(u);
                context.SaveChanges();

                return u;
            }
        }

        public bool UserExists(string username)
        {
            using (var context = new databaseEntities())
            {
                return (from x in context.Users where x.Username == username select x).Count() == 1;
            }
        }

        public UserModel LoginUser(string username, string password)
        {
            try
            {
                using (var context = new databaseEntities())
                {
                    return new UserModel((from x in context.Users where x.Username == username && x.Password == password select x).First());
                }
            }
            catch
            {
                return null;
            }
        }
    }
}