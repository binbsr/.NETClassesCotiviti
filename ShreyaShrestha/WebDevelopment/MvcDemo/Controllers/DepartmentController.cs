using Microsoft.AspNetCore.Mvc;
using MvcDemo.Data;
using MvcDemo.Models;
using System;
using System.Linq;

namespace MvcDemo.Controllers
{
    public class DepartmentController : Controller
    {
         OfficeContext db = new OfficeContext() ;
        
         public IActionResult DepartmentList() 
         {
             var departments = db.Departments.ToList();
             return View(departments);
         }
        
        [HttpGet]
        public IActionResult CreateDepartment() => View();
        
        [HttpPost]
         public IActionResult CreateDepartment(Department dept) 
            {
                      
                db.Departments.Add(dept);
                db.SaveChanges();

                return RedirectToAction("DepartmentList");
            }

        
    }
}