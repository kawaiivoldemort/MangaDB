using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MangaDB.Controllers
{
    public class HomeController : Controller
    {
        // HomePage Controller
        // Should return the front page
        public IActionResult Homepage()
        {
            return View();
        }
    }
    public class MangaListController : Controller
    {
        // List of Manga Controller
        // Should return a page catalouging manga
        public string MangaListPage()
        {
            return "Manga List Page";
        }
    }
}
