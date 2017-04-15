using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.MongoDB;

namespace MangaDB.Controllers
{
    public class LoginController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public LoginController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            // The UserManager is what we�ll be using to create users and generate validation tokens. 
            this._userManager = userManager;
            // SignInManager allows us to do password validation and sign in/out the users by managing the authentication cookies for us.
            this._signInManager = signInManager;
        }

        public IActionResult RegisterPage()
        {
            return View();
        }

        public IActionResult LoginPage()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> RegisterPage(string username, string email, string password, string retypePassword)
        {
            if (password != retypePassword)
            {
                ModelState.AddModelError(string.Empty, "Passwords don't match");
                return View();
            }

            var newUser = new IdentityUser
            {
                UserName = username,
                Email = email
            };

            var userCreationResult = await _userManager.CreateAsync(newUser, password);
            if (!userCreationResult.Succeeded)
            {
                foreach (var error in userCreationResult.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return View();
            }
            return Content("Account Created");
        }

        [HttpPost]
        public async Task<IActionResult> LoginPage(string username, string password)
        {
            Console.WriteLine("{0} {1}", username, password);
            var user = await _userManager.FindByNameAsync(username);
            if (user == null)
            {
                ModelState.AddModelError(string.Empty, "Invalid login");
                return View();
            }

            var passwordSignInResult = await _signInManager.PasswordSignInAsync(user, password, false, lockoutOnFailure: false);
            if (!passwordSignInResult.Succeeded)
            {
                ModelState.AddModelError(string.Empty, "Invalid login");
                return View();
            }

            return Redirect("~/");
        }
  
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Redirect("~/");
        }

        public async Task<JsonResult> GetUserDetails()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var r = new Random();
            // Fetch something from the db
            return Json(new {
                name = user.UserName,
                id = user.Email,
                ppn = r.Next() % 4
            });
        }
    }
}
