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



        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(StudentTable stu)
        {
            ViewData.Model = dbcontent.StudentTable.AsEnumerable();
            return View();
        }

        public ActionResult Delete(int id)
        {
            ViewData.Model = dbcontent.StudentTable.Where(u => u.id == id).FirstOrDefault();
            return View();
        }
        public ActionResult Edit(int id)
        {
            ViewData.Model = dbcontent.StudentTable.Where(u => u.id == id).FirstOrDefault();
            return View();
        }
        public ActionResult Details(int id)
        {
            ViewData.Model = dbcontent.StudentTable.Where(u => u.id == id).FirstOrDefault();
            return View();
        }
        [HttpPost]
        public ActionResult Delete(int id,FormCollection fc)
        {
            ViewData.Model = dbcontent.StudentTable.Find(id);
            return View();
        }

    }
}