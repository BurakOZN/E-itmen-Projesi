using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Manager;
using BLL.Repository;
using Entity.DataModel;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class AccountController : Controller
    {
        private IRepository<User> _userRep;
        public AccountController(IRepository<User> br)
        {
            _userRep = br;
        }
        [HttpGet]
        public async Task<IActionResult> Login()
        {
            UserManager um = new UserManager(_userRep);
            User user= um.Find(x => x.Email == "burakozn@gmail.com" && x.Id== "5cdc21af4d3c8d15d83d6cca");
            return await Task.Run(()=>View());
        }
        [HttpPost]
        public async Task<IActionResult> Login(User user)
        {

            return await Task.Run(() => View());
        }

    }
}