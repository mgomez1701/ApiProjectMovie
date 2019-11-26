using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieAPIProject.Models;

namespace MovieAPIProject.Controllers
{
    public class MovieAPIDbController : Controller
    {
        private readonly MovieAPIDbContext _database;

        public MovieAPIDbController(MovieAPIDbContext database)
        {
            _database = database;
        }
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult AddFavorites(Search searchMovie)
        {
            Favorites newMovie = new Favorites();
            newMovie.Imdbid = searchMovie.imdbID;
            newMovie.Name = searchMovie.Title;
            newMovie.Year = searchMovie.Year;
            newMovie.UserId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            if (ModelState.IsValid)
            {
                _database.Favorites.Add(newMovie);
                _database.SaveChanges();
            }
            return RedirectToAction("Index", "Home");
        }

        public IActionResult FavoriteList()
        {
            return View(_database.Favorites.ToList());
        }

        
    }


}