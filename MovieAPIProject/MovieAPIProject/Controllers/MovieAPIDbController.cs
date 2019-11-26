using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MovieAPIProject.Controllers
{
    public class MovieAPIDbController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}