using BlogIt.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlogIt.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogRepository _blogRepo;
        private readonly IUserRepository _userRepo;
        private readonly IWebHostEnvironment _hostEnvironment;

        public BlogController(IUserRepository userRepo, IBlogRepository blogRepo, IWebHostEnvironment hostEnvironment)
        {
            _blogRepo = blogRepo;
            _userRepo = userRepo;
            _hostEnvironment = hostEnvironment;
        }

        [HttpGet]
        public IActionResult uploadImage(string ticks) {
            ViewBag.ticks = ticks;
            return View("~/Views/Blog/ImageUpload.cshtml");
        }

        [HttpPost]
        public IActionResult uploadImage(IFormFile blogImage, string ticks) {
            Dictionary<string, string> result = new Dictionary<string, string>();
            
            if (blogImage != null)
            {
                // Save the image to the assets/images/users folder
                string wwwRootPath = _hostEnvironment.WebRootPath;
                string filename = ticks + Path.GetExtension(blogImage.FileName);
                string path = Path.Combine(wwwRootPath + "/assets/images/blogs/", filename);
                blogImage.CopyToAsync(new FileStream(path, FileMode.Create));
                result.Add("uploaded", "true");
            }

            return Redirect("/blog/create");
        }

        [HttpGet]
        public IActionResult Create() {
            User user = new User();
            user.Id = HttpContext.Session.GetInt32("user_id") ?? -1;
            user.Email = HttpContext.Session.GetString("user_email") ?? "";
            user.Name = HttpContext.Session.GetString("user_name") ?? "";
            user.ProfilePicUrl = HttpContext.Session.GetString("user_pic") ?? "";
            ViewBag.User = user;
            return View(viewName: "~/Views/Blog/CreateBlog.cshtml");
        }

        [HttpPost]
        public IActionResult Create(Blog blog, string trashImages, IFormFile blogImage) {
            blog.Author = _userRepo.GetUser(HttpContext.Session.GetInt32("user_id") ?? -1);
            blog.Published = false;

            string wwwRootPath = _hostEnvironment.WebRootPath;

            var trashImagesArr = trashImages.Split(" ");
            for (int i = 0; i < trashImagesArr.Length; i++) {
                string path = wwwRootPath + $"/assets/images/blogs/{trashImagesArr[i]}.png";
                System.GC.Collect();
                System.GC.WaitForPendingFinalizers();
                System.IO.File.Delete(path);
            }

            if (blog.Title != null && blog.Content != null && blog.Author != null && blog.DateTime != null)
            /*if (ModelState.ErrorCount)*/
            {
                if (blogImage != null)
                {
                    string filename = blog.Author.Id + "_" + blog.DateTime + "_"+ "blogImage_" + Path.GetExtension(blogImage.FileName);
                    string path = Path.Combine(wwwRootPath + "/assets/images/blogs", filename);
                    blogImage.CopyToAsync(new FileStream(path, FileMode.Create));
                    blog.TitleImageUrl = "/assets/images/blogs/" + filename;
                }
                else
                {
                    blog.TitleImageUrl = null;
                }

                Blog newBlog = _blogRepo.Add(blog);
                return Redirect("/user/dashboard");
            }

            return Redirect("/");
        }

        [HttpGet]
        public IActionResult ViewBlog(int Id) {
            Blog blog = _blogRepo.GetBlog(Id);
            if (blog != null)
            {
                User user = new User
                {
                    Id = HttpContext.Session.GetInt32("user_id") ?? -1,
                    Email = HttpContext.Session.GetString("user_email") ?? "",
                    Name = HttpContext.Session.GetString("user_name") ?? "",
                    ProfilePicUrl = HttpContext.Session.GetString("user_pic") ?? ""
                };
                ViewBag.user = user;
                ViewBag.blog = blog;
                return View(viewName: "~/Views/Blog/View.cshtml");
            }
            else
                return Redirect("/");
        }
    }
}
