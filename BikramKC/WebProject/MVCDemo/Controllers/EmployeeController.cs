using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MVCDemo.Data;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class EmployeeController: Controller
    {
        DataContext dbcon = new DataContext();
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(string FirstName, string LastName, string DOB)
        {
            
            Employee emp = new Employee()
            {
                FirstName = FirstName,
                LastName = LastName,
                DOB = DateTime.Parse(DOB)
            };
            dbcon.Employees.Add(emp);
            dbcon.SaveChanges();
            return RedirectToAction("List");

        }
        public IActionResult List()
        {
            var emps = dbcon.Employees.ToList();
            return View(emps);

        }
    }
}