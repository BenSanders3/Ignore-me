using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieDatabase.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace MovieDatabase.Controllers
{
    public class HomeController : Controller
    {
        private MediaContext context { get; set; }

        public HomeController(MediaContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var medias = context.Medias.OrderBy(m => m.Title).ToList();
            return View(medias);
        }
    }
}
