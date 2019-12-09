using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult getData(string txtname, string txtage, studentDemoaa aa)
        {
            return Content("已接受导数据");
        }
        
    }
    public class studentDemoaa
    {
        public string txtname { get; set; }
        public string  txtage { get; set; }
    }
}