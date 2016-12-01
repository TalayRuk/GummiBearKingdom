using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GummiBearKingdom.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace GummiBearKingdom.Controllers
{
    public class BlogsController : Controller
    {
        // GET: /<controller>/
        private GummiBearContext db = new GummiBearContext();
        public IActionResult Index()
        {
            //return list of blogs 
            return View(db.Blogs.ToList());
        }
    }
}
