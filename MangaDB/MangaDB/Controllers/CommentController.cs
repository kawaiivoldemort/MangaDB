using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using Comments;

namespace MangaDB.Controllers
{
    public class CommentsController : Controller
    {
        public IActionResult Comments(string mangaName)
        {
            return View();
        }
    }
    public class GetCommentsController : Controller
    {
        public async Task<JsonResult> GetCommentsAsync(string mangaName, int lastUpdated)
        {
            var result = await Task<JsonResult>.Run(() =>
            {
                while (!IfCommentsUpdated())
                {
                    Thread.Sleep(10);
                }
                return GetComments(mangaName, lastUpdated);
            });
            return result;
        }
        public bool IfCommentsUpdated()
        {
            return true;
        }
        public JsonResult GetComments(string mangaName, int lastUpdated)
        {
            Console.WriteLine("{0}:{1}", mangaName, lastUpdated);
            var replies = new List<Reply>();
            replies.Add(new Reply
            {
                username = "Nikhil Prabhu",
                uImgSrc = null,
                usernameTo = "Pradeep",
                content = "I AM NOT!!",
                date = DateTime.Now
            });
            var data = new List<Comment>();
            data.Add(new Comment
            {
                username = "Pradeep",
                uImgSrc = null,
                content = "Nikhil Prabhu is an old man",
                date = DateTime.Now,
                replies = replies
            });
            return Json(data);
        }
    }
}