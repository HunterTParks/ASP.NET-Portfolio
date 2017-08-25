using Microsoft.AspNetCore.Mvc;
using ASP_NET_Portfolio.Models;
using System.Collections.Generic;
using ASP_NET_Portfolio.ViewModels;

namespace ASP_NET_Portfolio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            UserRepos userRepos = new UserRepos();
            userRepos.user = GithubProfile.GetInfo();
            userRepos.starredRepos = GithubProfile.GetStarredRepos();
            return View(userRepos);
        }
    }
}
