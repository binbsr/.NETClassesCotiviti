using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MvcDemo.Data;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
         OfficeContext db = new OfficeContext();
        public object OfficeContext { get; private set; }

        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]

        public IActionResult Create(string FirstName, string LastName, string DOB)
        {
            

            Employee em = new Employee{FirstName = FirstName,LastName = LastName,DOB = DateTime.Parse(DOB)};

            db.Employees.Add(em);
            db.SaveChanges();

            return RedirectToAction("List");
           
            
        }

         public IActionResult List()
        {
            var employees = db.Employees.ToList();
            return View(employees);
        }



    }
}