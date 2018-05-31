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
    public class UsersController : Controller
    {
        internal UserService service = new UserService();

        public List<UserModel> GetAll()
        {
            return service.GetAllUsers();
        }

        public UserModel GetUserById(int id)
        {
            return service.GetUserById(id);
        }

        public UserModel RegisterUser(string username)
        {
            if (service.UserExists(username))
            {
                return null;
            }

            return new UserModel(service.CreateNewUser(username));
        }
    }
}
