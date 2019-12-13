using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            var departments = db.Departments.Select(x => new { x.Id, x.Name }).ToList();
            EmployeeViewModel employeeViewModel = new EmployeeViewModel 
            { 
                DD_Departments = new SelectList(departments, "Id", "Name")
            };

            return View(employeeViewModel);
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            db.Employees.Add(employee);
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