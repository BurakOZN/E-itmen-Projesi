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
        private IUserManager userManager;
        public AccountController(IUserManager userManager)
        {
            this.userManager = userManager;
        }
 
        [HttpGet]
        public async Task<IActionResult> Login()
        {
       
            return await Task.Run(()=>View());
        }
        [HttpPost]
        public async Task<IActionResult> Login(User user)
        {
            Login().Wait();
            StateUserM s = await userManager.AddUser(user); // 
            return await Task.Run(() => View());
        }

    }
}