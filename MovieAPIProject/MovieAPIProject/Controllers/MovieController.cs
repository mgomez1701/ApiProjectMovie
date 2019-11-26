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

            return View(movies);
        }


       
 
    }
}