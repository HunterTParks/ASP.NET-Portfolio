﻿using ASP.NET_Portfolio.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ASP.NET_Portfolio.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(GithubProfile.GetInfo());
        }
    }
}
