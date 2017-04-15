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
        public JsonResult Trending()
        {
            string trendingImagePath = "/images/TrendingPanel";
            string[] trendingImages = AccessoryFunctions.GetImages(trendingImagePath);
            var data = new List<string>();
            data.Add(trendingImagePath);
            foreach (var trendingImage in trendingImages)
            {
                data.Add(trendingImage);
            }
            return Json(data);
        }
        public JsonResult Ads()
        {
            string adImagePath = "/images/AdPanel";
            string[] adImages = AccessoryFunctions.GetImages(adImagePath);
            var data = new List<string>();
            data.Add(adImagePath);
            foreach (var adImage in adImages)
            {
                data.Add(adImage);
            }
            return Json(data);

        }
        public JsonResult New()
        {
            string newImagePath = "/images/NewPanel";
            string[] newImages = AccessoryFunctions.GetImages(newImagePath);
            var data = new List<string>();
            data.Add(newImagePath);
            foreach (var newImage in newImages)
            {
                data.Add(newImage);
            }
            return Json(data);
        }
        public JsonResult Favorites()
        {
            string allTimeFavoritesImagePath = "/images/AllTimeFavoritesPanel";
            string[] allTimeFavoritesImages = AccessoryFunctions.GetImages(allTimeFavoritesImagePath);
            var data = new List<string>();
            data.Add(allTimeFavoritesImagePath);
            foreach (var allTimeFavoritesImage in allTimeFavoritesImages)
            {
                data.Add(allTimeFavoritesImage);
            }
            return Json(data);
        }
        public JsonResult News()
        {
            var news = AccessoryFunctions.GetNews();
            return Json(news);
        }
    }
}
