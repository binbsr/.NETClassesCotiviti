using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcDemo.Data;
using MvcDemo.Models;


namespace MvcDemo.Controllers
{
    public class EmployeeController : Controller
    {
       OfficeContext db = new OfficeContext();
        [HttpGet]
          public IActionResult Create()
          {
             return View(); 
          } 

        [HttpPost]
          public IActionResult Create(string FirstName, string LastName, string Dob)
          {
             
             Employee emp = new Employee
             {
                FirstName=FirstName, 
                LastName= LastName, 
                DOB = DateTime.Parse(Dob)
             };
             db.Employees.Add(emp);
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