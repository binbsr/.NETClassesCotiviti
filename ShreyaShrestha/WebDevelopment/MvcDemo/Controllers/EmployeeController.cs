using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcDemo.Data;
using MvcDemo.Models;
using System;
using System.Linq;

namespace MvcDemo.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        //public ActionResult is also valid. as much as possible its better if we use interface in return statement
        public IActionResult Create() => View();
        OfficeContext db = new OfficeContext() ;
        [HttpPost]
        //  public IActionResult Create(Employees employees) 
        //  { OfficeContext db = new OfficeContext ;
        //  db.Employees.Add();
         //}

           public IActionResult Create(string firstName, string lastName, string dob) 
            {
              //OfficeContext db = new OfficeContext() ;
            Employees em = new Employees
            {
                FirstName = firstName,
                LastName = lastName,
                Dob = DateTime.Parse(dob)
            };
            db.Employees.Add(em);
            db.SaveChanges();

            return RedirectToAction("EmployeeList");
         }

         public IActionResult EmployeeList() 
         {
             var employees = db.Employees.ToList();
             return View(employees);
         }
        
        [HttpGet]
         public IActionResult Update(int id)
         {
             var employee = db.Employees.FirstOrDefault(x=> x.Id.Equals(id));
             return View(employee);
         }

         [HttpPost]
         public IActionResult Update(Employees employee)
         {
             db.Entry(employee).State = EntityState.Modified;
             db.SaveChanges();
             return RedirectToAction("EmployeeList");
         }
        
    }
}