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
        private readonly SQLUserBlogRepository _savedBlogRepo;
        private readonly SQLLikeBlogRepository _likedBlogRepo;
        private readonly SQLCommentBlogRepository _commentBlogRepo;
        private readonly IWebHostEnvironment _hostEnvironment;

        public BlogController(IUserRepository userRepo, IBlogRepository blogRepo,SQLCategoryRepository catRepo,SQLUserBlogRepository savedblogrepo, SQLLikeBlogRepository likeblogrepo, SQLCommentBlogRepository commentRepo,IWebHostEnvironment hostEnvironment)
        {
            _blogRepo = blogRepo;
            _userRepo = userRepo;
            _categoryRepo = catRepo;
            _savedBlogRepo = savedblogrepo;
            _likedBlogRepo = likeblogrepo;
            _commentBlogRepo = commentRepo;
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
        /*[Authorize]*/
        public IActionResult Create() {
            if(HttpContext.Session.GetInt32("user_id")==null){
                return Redirect("/user/login");
            }
            User user = new User();
            user.Id = HttpContext.Session.GetInt32("user_id") ?? -1;
            user.Email = HttpContext.Session.GetString("user_email") ?? "";
            user.Name = HttpContext.Session.GetString("user_name") ?? "";
            user.ProfilePicUrl = HttpContext.Session.GetString("user_pic") ?? "";
            ViewBag.User = user;
            IEnumerable<Category> categories = _categoryRepo.GetAllCategory();
            ViewBag.category = categories;
            return View(viewName: "~/Views/Blog/CreateBlog.cshtml");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Blog blog, string trashImages, IFormFile blogImage,int categoryId) {
            if(HttpContext.Session.GetInt32("user_id")==null){
                return View(viewName: "~/Views/User/Login.cshtml");
            }
            blog.Author = _userRepo.GetUser(HttpContext.Session.GetInt32("user_id") ?? -1);
            blog.views = 0;
            blog.Published = false;
            blog.category = _categoryRepo.GetCategory(categoryId);
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
        [Route("/blog/view/{Id}")]
        public IActionResult ViewBlog(int Id) {
            if(HttpContext.Session.GetInt32("user_id")==null){
                return Redirect("/user/login");
            }
            Blog blog = _blogRepo.GetBlog(Id);
            if (blog != null)
            {
                blog.views = blog.views + 1;
                _blogRepo.Update(blog);
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
        [Route("/blog")]
        [Route("/blog/explore")]
        [Route("/user/dashboard")]
        public IActionResult Explore()
        {
            if(HttpContext.Session.GetInt32("user_id")==null){
                return Redirect("/user/login");
            }
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
            ViewBag.IsExplore = true;
            return View(viewName: "~/Views/Blog/Explore.cshtml");

        }

        [HttpGet]
        public IActionResult SavedBlogs()
        {
            if(HttpContext.Session.GetInt32("user_id")==null){
                return Redirect("/user/login");
            }
            User user = new User();
            user.Id = HttpContext.Session.GetInt32("user_id") ?? -1;
            user.Email = HttpContext.Session.GetString("user_email") ?? "";
            user.Name = HttpContext.Session.GetString("user_name") ?? "";
            user.ProfilePicUrl = HttpContext.Session.GetString("user_pic") ?? "";
            ViewBag.User = user;

            IEnumerable<Category> categories = _categoryRepo.GetAllCategory();
            ViewBag.category = categories;
            var allBlogs = _savedBlogRepo.GetAllSavedBlogs();
            var result = from blog in allBlogs
                         where blog.UserId == HttpContext.Session.GetInt32("user_id")
                         select blog.Blog;
            ViewBag.blogs = result;
            ViewBag.IsSavedBlogs = true;
            return View(viewName: "~/Views/Blog/Explore.cshtml");
        }

        [HttpGet]
        public IActionResult FilterClicked(string category,string nameTitle)
        {
            if(HttpContext.Session.GetInt32("user_id")==null){
                return Redirect("/user/login");
            }
            User user = new User();
            user.Id = HttpContext.Session.GetInt32("user_id") ?? -1;
            user.Email = HttpContext.Session.GetString("user_email") ?? "";
            user.Name = HttpContext.Session.GetString("user_name") ?? "";
            user.ProfilePicUrl = HttpContext.Session.GetString("user_pic") ?? "";
            ViewBag.User = user;

            IEnumerable<Category> categories = _categoryRepo.GetAllCategory();
            ViewBag.category = categories;


            var blogs = _blogRepo.GetAllBlogs();

            // Regex regex = new Regex(@"?"+nameTitle, RegexOptions.IgnoreCase);

            /*Console.WriteLine("hello regex{0}", regex.ToString());*/


            var blogsForTesting = blogs;

            if (category != null)
            {
                int categ = int.Parse(category);
                if (categ != 0)
                {
                    ViewBag.categoryText = _categoryRepo.GetCategory(categ).type ?? "";
                    blogsForTesting = from blog in blogs
                                      where blog.category.Id == categ
                                      select blog;
                }
            }

            if (nameTitle != null)
            {

                var result = from blog in blogsForTesting
                            //  where ((regex.IsMatch(blog.Author.Name)) || regex.IsMatch(blog.Title))
                            where (blog.Author.Name).ToLower().Contains(nameTitle.ToLower()) || (blog.Title).ToLower().Contains(nameTitle.ToLower())
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

            ViewBag.categorySelected = category ?? "0";
            ViewBag.searchText = nameTitle ?? "";

            return View(viewName: "~/Views/Blog/Explore.cshtml");
        }

        [HttpGet]
        public IActionResult SaveBlog(string id)
        {
            if(HttpContext.Session.GetInt32("user_id")==null){
                return Redirect("/user/login");
            }
            Blog blog = _blogRepo.GetBlog(int.Parse(id));
            User user = _userRepo.GetUser((int)HttpContext.Session.GetInt32("user_id"));
            UserBlog saveBlog = new UserBlog();
            saveBlog.UserId = user.Id;
            saveBlog.User = user;
            saveBlog.BlogId = blog.Id;
            saveBlog.Blog = blog;
            var exist = _savedBlogRepo.GetUserBlog(user.Id,blog.Id);
            if(exist == null)
                _savedBlogRepo.Add(saveBlog);
            /*Console.WriteLine("hi");*/
            return Json(blog);
        }

        [HttpGet]
        public IActionResult UnsaveBlog(string id)
        {
            if(HttpContext.Session.GetInt32("user_id")==null){
                return Redirect("/user/login");
            }

            Console.WriteLine(id);

            Blog blog = _blogRepo.GetBlog(int.Parse(id));
            User user = _userRepo.GetUser((int)HttpContext.Session.GetInt32("user_id"));
            UserBlog saveBlog = new UserBlog();
            saveBlog.UserId = user.Id;
            saveBlog.User = user;
            saveBlog.BlogId = blog.Id;
            saveBlog.Blog = blog;
/*            _savedBlogRepo.DeleteBlog(saveBlog);
*/            return Json(null);
        }

        [HttpGet]
        public IActionResult MyBlog()
        {
            if(HttpContext.Session.GetInt32("user_id")==null){
                return Redirect("/user/login");
            }
            User user = new User();
            user.Id = HttpContext.Session.GetInt32("user_id") ?? -1;
            user.Email = HttpContext.Session.GetString("user_email") ?? "";
            user.Name = HttpContext.Session.GetString("user_name") ?? "";
            user.ProfilePicUrl = HttpContext.Session.GetString("user_pic") ?? "";
            ViewBag.User = user;

            IEnumerable<Category> categories = _categoryRepo.GetAllCategory();
            ViewBag.category = categories;

            var list = _blogRepo.GetAllBlogs();
            var result = from blog in list
                         where blog.Author.Id == HttpContext.Session.GetInt32("user_id")
                         select blog;

            ViewBag.blogs = result;
            ViewBag.IsMyBlog = true;
            return View(viewName: "~/Views/Blog/Explore.cshtml");
            
        }

        [HttpGet]
        public IActionResult LikedBlogs(int Id)
        {
            if(HttpContext.Session.GetInt32("user_id")==null){
                return Redirect("/user/login");
            }
            Blog blog = _blogRepo.GetBlog(Id);
            Console.WriteLine("in like controller");
            if (_likedBlogRepo.GetEntry(blog.Id, (int)HttpContext.Session.GetInt32("user_id")) == null){
                likeBlog blog_ = new likeBlog();
                blog_.blog = blog;
                blog_.UserId = (int)HttpContext.Session.GetInt32("user_id");
                blog_.BlogId = blog.Id;
                blog_.user = _userRepo.GetUser((int)HttpContext.Session.GetInt32("user_id"));   
                _likedBlogRepo.Add(blog_);
            }
            return Json(blog);
        }

        [HttpPost]
        public IActionResult Comment(int blogId, string comment)
        {
            if(HttpContext.Session.GetInt32("user_id")==null){
                return Redirect("/user/login");
            }
            Comment comment_ = new Comment();
            comment_.blog = _blogRepo.GetBlog(blogId);
            comment_.UserId = (int)HttpContext.Session.GetInt32("user_id");
            comment_.BlogId = blogId;
            comment_.dateTime = DateTime.Now;
            comment_.Text = comment;
            comment_.user = _userRepo.GetUser((int)HttpContext.Session.GetInt32("user_id"));
            _commentBlogRepo.Add(comment_);

            return Json(null);
        }
    }
}
