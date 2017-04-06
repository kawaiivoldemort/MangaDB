using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MangaMetadata;

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
        public JsonResult GetMangaMetadata(string mangaName)
        {
            var metadata = new MangaInfo
            {
                name = "Bleach",
                japaneseName = "ブリーチ",
                author = "Tite Kubo",
                publisher = "Shueisha",
                volumeCount = 74,
                chapterCount = 686,
                imageUri = "/images/AdPanel/f928b292.jpg",
                website = "https://www.viz.com/bleach",
                fansite = "http://www.fanpop.com/clubs/bleach-anime"
            };
            return Json(metadata);
        }
        public JsonResult GetMangaSummary(string mangaName)
        {
            var metadata = new MangaSummary
            {
                name = "Bleach",
                summary = "Ichigo Kurosaki never asked for the ability to see ghosts-- he was born with the gift.When his family is attacked by a Hollow-- a malevolent lost soul-- Ichigo becomes a Soul Reaper, dedicating his life to protecting the innocent and helping the tortured spirits themselves find peace."
            };
            return Json(metadata);
        }
        public JsonResult GetMangaChapters(string mangaName)
        {
            var chapters = new List<MangaChapter>();
            foreach(var v in Enumerable.Range(0, 686))
            {
                chapters.Add(new MangaChapter
                {
                    chapterNumber = v
                });
            }
            var volumes = new List<MangaVolume>();
            volumes.Add(new MangaVolume
            {
                volumeNumber = 1,
                chapters = chapters
            });
            var mangaChapters = new MangaChapters
            {
                name = "Bleach",
                volumes = volumes
            };
            return Json(mangaChapters);
        }
    }
}