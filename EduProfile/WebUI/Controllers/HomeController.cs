﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BLL.Repository;
using Entity.DataModel;
using Microsoft.AspNetCore.Mvc;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        IRepository<User> ur;
        public HomeController(IRepository<User> repository)
        {
            ur = repository;
        }
        public IActionResult Index()
        {
            User usr = new User() { Birth = DateTime.Now, CreatedAt = DateTime.Now, Email = "burakozn@gmail.com", LastName = "OZEN", Name = "Ahmet", CreatedBy = "Burak", PictureURL = "asdas", Password = "124", UpdatedAt = DateTime.Now, UpdatedBy = ".can" };

            //var a = br.Add(usr);
            //a.Wait();
            var test = ur.Get();
            test.Wait();
            List<User> users = test.Result;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
