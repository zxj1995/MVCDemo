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
        public ActionResult Create(StudentTable stu,FormCollection fc)
        {
            dbcontent.StudentTable.Add(stu);
            dbcontent.SaveChanges();
            return RedirectToAction("Index");
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
            StudentTable stu = new StudentTable();
            stu.id = id;

            dbcontent.StudentTable.Attach(stu);
            dbcontent.Entry(stu).State = System.Data.Entity.EntityState.Deleted;
            dbcontent.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Edit(int id, StudentTable stu)
        {
            
            dbcontent.Entry(stu).State = System.Data.Entity.EntityState.Modified;
            dbcontent.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}