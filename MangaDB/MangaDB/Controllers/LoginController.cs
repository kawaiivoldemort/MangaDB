using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.MongoDB;
using UserData;

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
            return Redirect("~/");
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
            if(_signInManager.IsSignedIn(User)) {
                await _signInManager.SignOutAsync();
            }
            return Redirect("~/");
        }

<<<<<<< HEAD
        public IActionResult UserInfo()
        {
            return View();
        }

        public JsonResult GetUserInfo()
        {
            var userdata = new UserInfo
            {
                username = "Guy",
                email = "Guy@website.com",
                profilePic = "/images/AdPanel/bakuman.jpg"
            };
            return Json(userdata);
=======
        public async Task<JsonResult> GetUserDetails()
        {
            if(_signInManager.IsSignedIn(User))
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
            else
            {
                return Json(null);
            }
>>>>>>> dc3975406fa00cb067a805fae743d0eb74f5dd94
        }
    }
}
