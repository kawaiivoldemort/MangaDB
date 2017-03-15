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
            var replies = new List<Reply>();
            replies.Add(new Reply
            {
                username = "Nikhil Prabhu",
                uImgSrc = "/images/AdPanel/f928b292.jpg",
                usernameTo = "Pradeep",
                content = "I AM NOT!!",
                date = DateTime.Now
            });
            replies.Add(new Reply
            {
                username = "Naveen Patel",
                uImgSrc = "/images/AdPanel/f928b292.jpg",
                usernameTo = "Nikhil Prabhu",
                content = "Of course you are",
                date = DateTime.Now
            });
            var data = new List<Comment>();
            data.Add(new Comment
            {
                username = "Pradeep",
                uImgSrc = "/images/AdPanel/f928b292.jpg",
                content = "Nikhil Prabhu is an old man",
                date = DateTime.Now,
                replies = replies
            });
            data.Add(new Comment
            {
                username = "Pradyumna",
                uImgSrc = "/images/AdPanel/f928b292.jpg",
                content = "This article is stupid",
                date = DateTime.Now,
                replies = new List<Reply>()
            });
            return Json(data);
        }
    }
}