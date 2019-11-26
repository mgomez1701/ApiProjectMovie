using System;
using System.Collections.Generic;

namespace MovieAPIProject.Models
{
    public partial class Favorites
    {
        public string Name { get; set; }
        public string Imdbid { get; set; }
        public string Year { get; set; }
        public string UserId { get; set; }
    }
}
