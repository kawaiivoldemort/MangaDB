using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MangaMetadata;

namespace MangaDB.Controllers
{
    public class MangaListController : Controller
    {
        // List of Manga Controller
        // Should return a page catalouging manga
        public IActionResult MangaListPage()
        {
            return View();
        }
        public JsonResult MangaListData()
        {
            var list = new List<MangaListItem>();
            list.Add(new MangaListItem {
                name = "bleach",
                imageUri = "/images/MangaImages/bleach.jpg",
                ifAliased = false,
                alias = null
            });
            list.Add(new MangaListItem {
                name = "naruto",
                imageUri = "/images/MangaImages/bleach.jpg",
                ifAliased = false,
                alias = null
            });
            list.Add(new MangaListItem {
                name = "konosuba",
                imageUri = "/images/MangaImages/bleach.jpg",
                ifAliased = false,
                alias = null
            });
            list.Add(new MangaListItem {
                name = "erased",
                imageUri = "/images/MangaImages/bleach.jpg",
                ifAliased = false,
                alias = null
            });
            list.Add(new MangaListItem {
                name = "inuyasha",
                imageUri = "/images/MangaImages/bleach.jpg",
                ifAliased = false,
                alias = null
            });
            return Json(list);
        }
    }
}