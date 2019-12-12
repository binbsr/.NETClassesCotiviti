using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MVCDemo.Data;
using MVCDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace MVCDemo.Controllers {
    public class DepartmentController : Controller {
        OfficeContext db = new OfficeContext ();
        public IActionResult Create () {
            return View ();
        }

        [HttpPost]
  
            public IActionResult Create (Department dept) {
            
            db.Departments.Add (dept);
            db.SaveChanges ();

            return RedirectToAction ("List");

        }

        

        [HttpGet]       

        public IActionResult List () {
            var dept = db.Departments.ToList ();
            return View (dept);
        }

    }
}