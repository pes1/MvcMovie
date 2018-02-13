using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }


        //public string Index()
        //{
        //    return "This is my <b>default</b> action...";
        //}

        // 
        // GET: /HelloWorld/Welcome/ 
        //- Anropas med
        //- h ttp://localhost:50094/HelloWorld/Welcome/1?name=Scott

       // public string Welcome(string name, int ID = 1)
        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
            //return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        }



        //- h ttp://localhost:50094/HelloWorld/Welcome?name=Nisse&numtimes=5
        //- Skriver ut följande på WEBsidan: Hello Nisse, NumTimes is: 5

        //public string Welcome(string name, int numTimes = 1)
        //{
        //    return HttpUtility.HtmlEncode("Hello " 
        //        + name 
        //        + ", NumTimes is: " 
        //        + numTimes);
        //}


        //public string Welcome()
        //{
        //    return "This is the Welcome action method...";
        //}
    }
}