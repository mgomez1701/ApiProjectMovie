using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieAPIProject.Models;

namespace MovieAPIProject.Controllers
{
    public class MovieController : Controller
    {
        
        private readonly HttpClient _client;

        public MovieController(IHttpClientFactory client)
        {
            _client = client.CreateClient();
            _client.BaseAddress = new Uri("http://www.omdbapi.com/");
        }
        public async Task<IActionResult> DisplaySearch(string input)
        {
            var response = await _client.GetAsync($"?s={input}&apikey=425dbd7b");
            var movies = await response.Content.ReadAsAsync<SearchRoot>();
            if (movies.Response == "False")
            {
                return RedirectToAction("ErrorPage", "Home");
            }
            return View(movies);
        }

        public async Task<IActionResult> DisplayByYear(string input, string year)
        {
            var response = await _client.GetAsync($"?t={input}&y={year}&apikey=425dbd7b");
            var movies = await response.Content.ReadAsAsync<SearchRoot>();
            if (movies.Response == "False")
            {
                return RedirectToAction("ErrorPage", "Home", "Please input a correct year");
            }
            return View(movies);
        }
       
 
    }
}