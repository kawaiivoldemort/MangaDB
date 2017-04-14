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
                name = "Bleach",
                imageUri = "/images/MangaImages/bleach.jpg",
                linkName = "bleach"
            });
            list.Add(new MangaListItem {
                name = "Bllom",
                imageUri = "/images/MangaImages/bleach.jpg",
                linkName = "bleach"
            });
            list.Add(new MangaListItem {
                name = "Black",
                imageUri = "/images/MangaImages/bleach.jpg",
                linkName = "bleach"
            });
            list.Add(new MangaListItem {
                name = "Briny",
                imageUri = "/images/MangaImages/bleach.jpg",
                linkName = "bleach"
            });
            list.Add(new MangaListItem {
                name = "Boffle",
                imageUri = "/images/MangaImages/bleach.jpg",
                linkName = "bleach"
            });
            list.Add(new MangaListItem {
                name = "Booked",
                imageUri = "/images/MangaImages/bleach.jpg",
                linkName = "bleach"
            });
            list.Add(new MangaListItem {
                name = "Bandana",
                imageUri = "/images/MangaImages/bleach.jpg",
                linkName = "bleach"
            });
            list.Add(new MangaListItem {
                name = "Naruto",
                imageUri = "/images/MangaImages/bleach.jpg",
                linkName = "naruto"
            });
            list.Add(new MangaListItem {
                name = "Konosuba",
                imageUri = "/images/MangaImages/bleach.jpg",
                linkName = "konosuba"
            });
            list.Add(new MangaListItem {
                name = "Erased",
                imageUri = "/images/MangaImages/bleach.jpg",
                linkName = "erased"
            });
            list.Add(new MangaListItem {
                name = "Inuyasha",
                imageUri = "/images/MangaImages/bleach.jpg",
                linkName = "inuyasha"
            });
            return Json(list);
        }
    }
}