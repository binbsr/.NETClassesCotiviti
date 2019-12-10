using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using MvcDemo.Data;
using MvcDemo.Models; 

namespace MvcDemo.Controllers{

    public class EmployeeController: Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(string FirstName,string LastName,string Dob)//Binding varables from form
        {
            OfficeContext db = new OfficeContext();
            Employee em = new Employee
            {
                FirstName=FirstName,
                LastName=LastName,
                DOB = DateTime.Parse(Dob)
            };
            db.Employees.Add(em);
            db.SaveChanges();

            return RedirectToAction("List");

        }
        public IActionResult List()
        {
            OfficeContext db = new OfficeContext();
           var Employees = db.Employees.ToList();
           return View(Employees);

        }

    }

}