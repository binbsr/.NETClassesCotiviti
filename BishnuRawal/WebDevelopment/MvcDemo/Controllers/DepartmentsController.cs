using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MvcDemo.Data;
using MvcDemo.Models;

namespace MvcDemo.Controllers
{
    public class DepartmentsController : Controller
    {
        OfficeContext db = new OfficeContext();

        public IActionResult List()
        {         
            var departments = db.Departments.ToList();
            return View(departments);
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Department department)
        {
            db.Departments.Add(department);
            db.SaveChanges();
            
            return RedirectToAction("List");
        }
    }
}