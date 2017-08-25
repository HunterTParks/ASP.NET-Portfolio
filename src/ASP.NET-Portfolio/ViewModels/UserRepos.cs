using ASP_NET_Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Portfolio.ViewModels
{
    public class UserRepos
    {
        GithubProfile user = GithubProfile.GetInfo();
        List<Models.Repos> starredRepos = GithubProfile.GetStarredRepos();
    }
}
