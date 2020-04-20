using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Lab6.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Lab6.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            var result = await client.GetAsync("https://cst8359lab6server.azurewebsites.net/api/twitter/getlast100tweets");

            var content = await result.Content.ReadAsStringAsync();

            var tweets = JsonConvert.DeserializeObject<List<Tweet>>(content);

            return View(tweets.OrderByDescending(o => o.TweetId));
        }

        [HttpPost]
        public async Task<IActionResult> PostTweet()
        {
            var tweet = new Tweet();
            tweet.Username = HttpContext.Request.Form["username"];
            tweet.Content = HttpContext.Request.Form["content"];

            var json = JsonConvert.SerializeObject(tweet);

            var httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            var client = new HttpClient();
            await client.PostAsync("https://cst8359lab6server.azurewebsites.net/api/twitter/add", httpContent);

            return RedirectToAction("Index");
        }
    }
}