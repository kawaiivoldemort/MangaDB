using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MangaDB.Controllers
{
    public class UsersController : Controller
    {
        // HomePage Controller
        // Should return the front page
        public IActionResult Signin()
        {
            return View();
        }

        public IActionResult UserInfo()
        {
            return View();
        }
    }
}
