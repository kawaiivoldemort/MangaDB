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
            return "Manga Page";
        }
    }
    public class CommentsController : Controller
    {
        // List of Comments Controller
        // Should return a list of comments in XML a la disqus
        public string ListComments(string mangaName)
        {
            return "Comments of " + mangaName;
        }
    }
}
