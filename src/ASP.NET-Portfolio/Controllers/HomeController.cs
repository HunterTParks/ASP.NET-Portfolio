using Microsoft.AspNetCore.Mvc;
using ASP_NET_Portfolio.Models;
using System.Collections.Generic;

namespace ASP_NET_Portfolio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(GithubProfile.GetInfo());
        }
    }
}
