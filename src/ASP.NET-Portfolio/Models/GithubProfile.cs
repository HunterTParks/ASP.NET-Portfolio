using ASP.NET_Portfolio.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Authenticators;
using System.Threading.Tasks;

namespace ASP.NET_Portfolio.Models
{
    public class GithubProfile
    {
        public class RootObject
        {
            public string login { get; set; }
            public int id { get; set; }
            public string avatar_url { get; set; }
            public string gravatar_id { get; set; }
            public string url { get; set; }
            public string html_url { get; set; }
            public string followers_url { get; set; }
            public string following_url { get; set; }
            public string gists_url { get; set; }
            public string starred_url { get; set; }
            public string subscriptions_url { get; set; }
            public string organizations_url { get; set; }
            public string repos_url { get; set; }
            public string events_url { get; set; }
            public string received_events_url { get; set; }
            public string type { get; set; }
            public bool site_admin { get; set; }
            public string name { get; set; }
            public string company { get; set; }
            public string blog { get; set; }
            public string location { get; set; }
            public string email { get; set; }
            public bool hireable { get; set; }
            public string bio { get; set; }
            public int public_repos { get; set; }
            public int public_gists { get; set; }
            public int followers { get; set; }
            public int following { get; set; }
            public string created_at { get; set; }
            public string updated_at { get; set; }
            public int total_private_repos { get; set; }
            public int owned_private_repos { get; set; }
            public int private_gists { get; set; }
            public int disk_usage { get; set; }
            public int collaborators { get; set; }

            public static GithubProfile GetInfo()
            {
                var client = new RestClient("https://api.github.com");
                var request = new RestRequest("/user?access_token=" + EnvironmentalVariables.AuthToken);
                var response = new RestResponse();

                Task.Run(async () =>
                {
                    response = await GetResponseContentAsync(client, request) as RestResponse;
                }).Wait();

                JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(response.Content);
                var user = JsonConvert.DeserializeObject<GithubProfile>(jsonResponse["content"].ToString());
                return user;
            }

            public static Task<IRestResponse> GetResponseContentAsync(RestClient theClient, RestRequest theRequest)
            {
                var tcs = new TaskCompletionSource<IRestResponse>();
                theClient.ExecuteAsync(theRequest, response => {
                    tcs.SetResult(response);
                });
                return tcs.Task;
            }
        }
}
