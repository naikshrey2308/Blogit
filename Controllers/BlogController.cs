using BlogIt.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BlogIt.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogRepository _blogRepo;
        private readonly IUserRepository _userRepo;
        private readonly SQLCategoryRepository _categoryRepo;
       /* private readonly SQLSavedBlogRepository _savedBlogRepo;*/
        private readonly IWebHostEnvironment _hostEnvironment;

        public BlogController(IUserRepository userRepo, IBlogRepository blogRepo,SQLCategoryRepository catRepo, IWebHostEnvironment hostEnvironment)
        {
            _blogRepo = blogRepo;
            _userRepo = userRepo;
            _categoryRepo = catRepo;
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
            /*blog.DateTime = (string)DateTime.Now;*/

            string wwwRootPath = _hostEnvironment.WebRootPath;

            if (trashImages == null)
            {

            }
            else
            {
                var trashImagesArr = trashImages.Split(" ");
                for (int i = 0; i < trashImagesArr.Length; i++)
                {
                    string path = wwwRootPath + $"/assets/images/blogs/{trashImagesArr[i]}.png";
                    System.GC.Collect();
                    System.GC.WaitForPendingFinalizers();
                    System.IO.File.Delete(path);
                }
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
                return Redirect("/blog/explore");
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

        [HttpGet]
        public IActionResult Explore()
        {
            User user = new User();
            user.Id = HttpContext.Session.GetInt32("user_id") ?? -1;
            user.Email = HttpContext.Session.GetString("user_email") ?? "";
            user.Name = HttpContext.Session.GetString("user_name") ?? "";
            user.ProfilePicUrl = HttpContext.Session.GetString("user_pic") ?? "";
            ViewBag.User = user;

            IEnumerable<Category> categories = _categoryRepo.GetAllCategory();
            ViewBag.category = categories;


            var blogs = _blogRepo.GetAllBlogs();
           /* var users = _userRepo.GetAllUsers();
            var result = from blog in blogs
                         join author in users
                         on blog.Author.Id equals author.Id
                         select new
                         {
                             id = blog.Id,
                             profile = author.ProfilePicUrl ?? "shruti29@gmail.com.jpg",
                             name = author.Name,
                             title = blog.Title,
                             content = blog.Content
                         };
            foreach (var i in result)
            {
                Console.WriteLine($"\"{i.name}\" {blogs.ToList()[0].Author.Name} is owned by {i.title}");
            }*/

            ViewBag.blogs = blogs;
            return View(viewName: "~/Views/Blog/Explore.cshtml");

        }

        [HttpGet]
        public IActionResult FilterClicked(string category,string nameTitle)
        {
            User user = new User();
            user.Id = HttpContext.Session.GetInt32("user_id") ?? -1;
            user.Email = HttpContext.Session.GetString("user_email") ?? "";
            user.Name = HttpContext.Session.GetString("user_name") ?? "";
            user.ProfilePicUrl = HttpContext.Session.GetString("user_pic") ?? "";
            ViewBag.User = user;

            IEnumerable<Category> categories = _categoryRepo.GetAllCategory();
            ViewBag.category = categories;


            var blogs = _blogRepo.GetAllBlogs();

            Regex regex = new Regex(@"^"+nameTitle, RegexOptions.IgnoreCase);

            /*Console.WriteLine("hello regex{0}", regex.ToString());*/

            int categ = int.Parse(category);

            var blogsForTesting = blogs;

            if(categ != 0)
            {
                blogsForTesting = from blog in blogs
                                  where blog.category.Id == categ
                                  select blog;
            }

            if (nameTitle != null)
            {

                var result = from blog in blogsForTesting
                             where ((regex.IsMatch(blog.Author.Name)) || regex.IsMatch(blog.Title))
                             select blog;

                foreach (var a in result)
                {
                    Console.WriteLine(a.Title);
                }

                ViewBag.blogs = result;
            }

            else
            {
                ViewBag.blogs = blogsForTesting;
            }

            return View(viewName: "~/Views/Blog/Explore.cshtml");
        }

        // [HttpGet]
        // public IActionResult SaveBlog(string id)
        // {
        //     Blog blog = _blogRepo.GetBlog(int.Parse(id));
        //     User user = _userRepo.GetUser((int)HttpContext.Session.GetInt32("user_id"));
        //     _savedBlogRepo.Add(user, blog);
        //     return Json(blog);
        // }
    }
}
