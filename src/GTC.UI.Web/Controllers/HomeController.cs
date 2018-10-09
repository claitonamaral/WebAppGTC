using GTC.UI.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Raven.Client.Documents;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace GTC.UI.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //[HttpPost]
        //public ActionResult Post([FromBody]User user)
        //{
        //    if (user == null)
        //    {
        //        return NotFound("Sorry !!");
        //    }

        //    var ds = new DocumentStore()
        //    {
        //        Database = "GTC",
        //        Urls = new[] { "http://127.0.0.1:8080" }
        //    }.Initialize();

        //    using (var session = ds.OpenSession())
        //    {
        //        session.Store(user);
        //        session.SaveChanges();
        //    }

        //    return Ok("Congratulations !!");
        //}

        //[HttpGet]
        //public IList Get()
        //{
        //    IList users = new List<User>();
        //    var ds = new DocumentStore()
        //    {
        //        Database = "GTC",
        //        Urls = new[] { "http://127.0.0.1:8080" }
        //    }.Initialize();

        //    using (var session = ds.OpenSession())
        //    {
        //        users = (from user in session.Query<User>()
        //                 select user).ToList();
        //    }

        //    return users;
        //}

        //[HttpGet("{id}")]
        //public User Get(Guid id)
        //{
        //    var ds = new DocumentStore()
        //    {
        //        Database = "GTC",
        //        Urls = new[] { "http://127.0.0.1:8080" }
        //    }.Initialize();

        //    using (var session = ds.OpenSession())
        //    {
        //        return session.Load<User>("users/" + id);
        //    }

        //}


    }
}
