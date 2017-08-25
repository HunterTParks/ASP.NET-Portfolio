using ASP_NET_Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_NET_Portfolio.ViewModels
{
    public class UserRepos
    {
        public GithubProfile user { get; set; }
        public List<Repos> starredRepos { get; set; }
    }
}
