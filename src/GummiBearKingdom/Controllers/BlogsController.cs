using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GummiBearKingdom.Models;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace GummiBearKingdom.Controllers
{
    public class BlogsController : Controller
    {
        // GET: /<controller>/
        private GummiBearContext db = new GummiBearContext();
        public IActionResult Index()
        {
            //add arrange blog by newest first 
            var thisBlog = db.Blogs.OrderByDescending(b => b.BlogId);
            //return list of blogs 
            return View(thisBlog.ToList());
        }
        public IActionResult Details(int id)
        {
            var thisBlog = db.Blogs.FirstOrDefault(b => b.BlogId == id);
            return View(thisBlog);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Blog blog)
        {
            db.Blogs.Add(blog);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var thisBlog = db.Blogs.FirstOrDefault(b => b.BlogId == Id);
            return View(thisBlog);
        }

        [HttpPost]
        public IActionResult Edit(Blog blog)
        {
            db.Entry(blog).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var thisBlog = db.Blogs.FirstOrDefault(b => b.BlogId == id);
            return View(thisBlog);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisBlog = db.Blogs.FirstOrDefault(b => b.BlogId == id);
            db.Blogs.Remove(thisBlog);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
