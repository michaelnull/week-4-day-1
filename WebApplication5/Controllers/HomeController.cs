using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            ViewBag.Message = "";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        Classmate a = new Classmate("Brandon", 71, "brown");
      
       
    }
                        
    public class Classmate
    {
        string Name { get; set; }
        int Height { get; set; }
        string Hair { get; set; }
        public Classmate(string name, int height, string hair)
        {
            this.Name = name;
            this.Height = height;
            this.Hair = hair;
        }
    }
    
}