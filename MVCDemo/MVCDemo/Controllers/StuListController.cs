using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class StuListController : Controller
    {
        // GET: StuList
        StudentLoginEntities dbcontent = new StudentLoginEntities();
        public ActionResult Index()
        {
            ViewData.Model = dbcontent.StudentTable.AsEnumerable();
            return View();
        }
    }
}