using Assignment1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Controllers
{
    public class HomeController : Controller
    {
        private Assignment1DataContext _DataContext;

        public HomeController(Assignment1DataContext context)
        {
            _DataContext = context;
        }

        public IActionResult Index()
        {
            var blogPosts = _DataContext.BlogPosts.ToList();
            blogPosts.Reverse();

            return View(blogPosts);
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult RegisterUser(User user)
        {
            _DataContext.Users.Add(user);
            _DataContext.SaveChanges();

            return RedirectToAction("Login");
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult LoginUser(User user)
        {

            var u = (from validateUser in _DataContext.Users where validateUser.EmailAddress == user.EmailAddress && validateUser.Password == user.Password select validateUser).FirstOrDefault();

            if (u != null)
            {
                HttpContext.Session.SetInt32("_userId", u.UserId);
                HttpContext.Session.SetInt32("_roleId", u.RoleId);
                HttpContext.Session.SetString("_firstName", u.FirstName);
                HttpContext.Session.SetString("_lastName", u.LastName);

                return RedirectToAction("Index");
            } else
            {
                return RedirectToAction("Login");
            }
        }

        public IActionResult Logoff()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Index");
        }

        public IActionResult DisplayFullBlogPost(int id)
        {
            var blogPost = new FullBlogPost();
            blogPost.commentView = new List<CommentView>();

            var post = (from b in _DataContext.BlogPosts where b.BlogPostId == id select b).FirstOrDefault();
            blogPost.blog = post;

            var user = (from u in _DataContext.Users where post.UserId == u.UserId select u).FirstOrDefault();
            blogPost.user = user;

            var comments = (from item in _DataContext.Comments where item.BlogPostId == id select item).ToList();
            foreach (Comment com in comments)
            {
                CommentView c = new CommentView();
                c.comment = com;
                var author = (from u in _DataContext.Users where u.UserId == com.UserId select u).FirstOrDefault();
                c.authorName = author.FirstName + " " + author.LastName;
                c.authorEmail = author.EmailAddress;
                blogPost.commentView.Add(c);
            }

            return View(blogPost);
        }

        public IActionResult AddComment(Comment comment)
        {
            _DataContext.Comments.Add(comment);
            _DataContext.SaveChanges();

            return RedirectToAction("DisplayFullBlogPost/" + comment.BlogPostId);
        }

        public IActionResult AddBlogPost()
        {
            return View();
        }

        public IActionResult CreateBlogPost(BlogPost blog)
        {
            _DataContext.BlogPosts.Add(blog);
            _DataContext.SaveChanges();

            return RedirectToAction("DisplayFullBlogPost/" + blog.BlogPostId);
        }

        public IActionResult EditBlogPost(int id)
        {
            var blog = (from b in _DataContext.BlogPosts where b.BlogPostId == id select b).FirstOrDefault();
            
            return View(blog);
        }

        public IActionResult EditBlog(BlogPost blog)
        {
            var blogPost = (from b in _DataContext.BlogPosts where b.BlogPostId == blog.BlogPostId select b).FirstOrDefault();
            blogPost.Title = blog.Title;
            blogPost.Posted = blog.Posted;
            blogPost.Content = blog.Content;

            _DataContext.SaveChanges();

            return RedirectToAction("DisplayFullBlogPost/" + blog.BlogPostId);
        }
    }
}
