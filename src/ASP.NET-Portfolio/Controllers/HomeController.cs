using ASP_NET_Portfolio.Models;
using Microsoft.AspNetCore.Mvc;

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
