using BlogIt.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using Microsoft.AspNetCore.Authorization;

namespace BlogIt.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepo;
        private readonly IWebHostEnvironment _hostEnvironment;


        public UserController(IUserRepository userRepo, IWebHostEnvironment hostEnvironment) {
            _userRepo = userRepo;
            _hostEnvironment = hostEnvironment;
        }

        [HttpGet]
        public IActionResult Login() {
            if (HttpContext.Session.GetString("user_email") != null)
                return Redirect("/user/dashboard");
            else
                return View(viewName: "~/Views/User/Login.cshtml");
        }

        [HttpPost]
        public IActionResult Login(string email, string password) {
            User user = _userRepo.GetUserFromEmail(email);
            if (user == null)
            {
                /* No user is found */
                return Redirect("/User/Login?err=email");
            }
            else if (user.Password != password) {
                /* Password is incorrect */
                return Redirect("/User/Login?err=password");
            }

            /* Good to go, user logged in */
            HttpContext.Session.SetString("user_email", user.Email);
            HttpContext.Session.SetString("user_name", user.Name);
            HttpContext.Session.SetString("user_pic", user.ProfilePicUrl!=null?user.ProfilePicUrl:"shruti2903@gmail.com.png");
            HttpContext.Session.SetInt32("user_id", user.Id);

            return Redirect("/blog/explore");
        }

        [HttpGet]
        public IActionResult Register() {
            if (HttpContext.Session.GetString("user_email") != null)
                return Redirect("/user/dashboard");
            else
                return View(viewName: "~/Views/User/Register.cshtml");
        }

        [HttpPost]
        public IActionResult Register(IFormFile profilePic, string cpass, User user)
        {
            if (ModelState.IsValid) {

                if (user.Email.Equals("") || user.Name.Equals("") || user.Password.Equals(""))
                    return Redirect("/user/register?err=missing");

                if (!cpass.Equals(user.Password))
                    return Redirect("/user/register?err=pass");

                if (profilePic != null)
                {
                    // Save the image to the assets/images/users folder
                    string wwwRootPath = _hostEnvironment.WebRootPath;
                    string filename = user.Email + Path.GetExtension(profilePic.FileName);
                    string path = Path.Combine(wwwRootPath + "/assets/images/users", filename);
                    profilePic.CopyToAsync(new FileStream(path, FileMode.Create));
                    user.ProfilePicUrl = "/assets/images/users/" + filename;
                }
                else
                {
                    user.ProfilePicUrl = "~/assets/images/users/default.png";
                }
                 
                User newUser = _userRepo.Add(user);

                HttpContext.Session.SetString("user_email", newUser.Email);
                HttpContext.Session.SetString("user_name", newUser.Name);
                HttpContext.Session.SetString("user_pic", newUser.ProfilePicUrl ?? "");
                HttpContext.Session.SetInt32("user_id", newUser.Id);


                return Redirect("/User/Dashboard");
            }
            return Redirect("~/Views/User/Register.cshtml");
        }

        [HttpGet]
        public IActionResult updateProfile()
        {
            User user = _userRepo.GetUser((int)HttpContext.Session.GetInt32("user_id"));
    
            ViewBag.User = user;
            return View(viewName: "~/Views/User/UpdateProfile.cshtml");
        }

        [HttpPost]
        public IActionResult updateProfile(IFormFile profilePic,int Id,string name,string password)
        {
            Console.WriteLine("haa bhai"+profilePic);
            User user = _userRepo.GetUser(Id);

            if (profilePic != null)
            {
                // Save the image to the assets/images/users folder
                if(user.ProfilePicUrl!= "~/assets/images/users/default.png")
                    System.IO.File.Delete(user.ProfilePicUrl);
                string wwwRootPath = _hostEnvironment.WebRootPath;
                string filename = user.Email + Path.GetExtension(profilePic.FileName);
                string path = Path.Combine(wwwRootPath + "/assets/images/users", filename);
                profilePic.CopyToAsync(new FileStream(path, FileMode.Create));
                user.ProfilePicUrl = "~/assets/images/users/" + filename;
            }
            
            if(name != null)
                user.Name = name;

            if(password != null)
                user.Password = password;

            _userRepo.Update(user);

            ViewBag.User = user;

            return View(viewName: "~/Views/User/UpdateProfile.cshtml");
        }
     
        public IActionResult Logout() {
            HttpContext.Session.Clear();
            return Redirect("/user/login");
        }
    }
}
