using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MangaDB.Controllers
{
    public class MangaController : Controller
    {
        // MangaPage Controller
        public IActionResult MangaPage(string mangaName)
        {
            ViewData["mangaName"] = mangaName;
            return View();
        }
    }
}