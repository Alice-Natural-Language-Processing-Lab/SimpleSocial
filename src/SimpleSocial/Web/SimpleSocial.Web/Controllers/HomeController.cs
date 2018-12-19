﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SimpleSocial.Web.Models;

namespace SimpleSocial.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("MyProfile","Account");
            }

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = $"My app has users.";

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
