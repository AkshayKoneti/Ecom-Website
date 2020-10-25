

using CommonLayer.Models;
using DataAccessLayer;
using DataAccessLayer.Models;
using DemoWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace DemoWeb.Controllers
{
    public class AuctionController : Controller
    {
        // GET: Auction
        public ActionResult Index()
        {
            var Emp = new[] {

                new DemoWeb.Models.Auction()
            {
                id = 1,
                Title = "Subash",
                startDate = DateTime.Now,
                ImageUrl = "nice"
            },

                new DemoWeb.Models.Auction()
            {
                id = 2,
                Title = "Sukesh",
                startDate = DateTime.Now,
                ImageUrl = "Gud Morning"
            }
            };

            return View(Emp);
        }

        public ActionResult Auction()
        {
            var Emp = new DemoWeb.Models.Auction()
            {
        
            Title = "Subash",
            startDate = DateTime.Now,
            ImageUrl = "Hello Subash"
            };
            var Emp1 = new DemoWeb.Models.Auction()
            {

                Title = "Sukesh",
                startDate = DateTime.Now,
                ImageUrl = "Hello Sukesh"
            };

            List<Auction> a = new List<Auction>();
            a.Add(Emp);
            a.Add(Emp1);
             



            return View("Index",a);
        }

        public ActionResult two() {


            TempData["Key"] = "Sucess";
            return RedirectToAction("Index");
        }

        public ActionResult Three()
        {

            if (TempData["Key"] != null)
            {
                String data = (String)TempData["Key"];
                TempData.Keep();
            }
            return View();
        }

        [HttpGet]
        public ActionResult create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult create(DemoWeb.Models.Auction auction)
        {
            if (auction != null)
            {
                return RedirectToAction("index");
            }
            return create();
        }

        //public ActionResult GetRegistersUser()
        //{
        //    Repository r = new Repository();
        //    List<CommonLayer.Models.Register> e = r.get();
           
        //    return View(e);
       // }
    }
}