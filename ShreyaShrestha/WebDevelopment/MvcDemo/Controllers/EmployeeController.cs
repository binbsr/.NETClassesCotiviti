using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
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
        // public IActionResult Create() => View();
        public IActionResult Create()
        {
            var departments = db.Departments.Select(x => new {x.Id, x.Name}).ToList();
            EmployeeViewModel employeeViewModel = new EmployeeViewModel
            {
                DD_Departments = new SelectList(departments, "Id","Name")
            };

            return View(employeeViewModel);
        }

        OfficeContext db = new OfficeContext() ;

        [HttpPost]
        //  public IActionResult Create(Employees employees) 
        //  { OfficeContext db = new OfficeContext ;
        //  db.Employees.Add();
         //}

        //    public IActionResult Create(string firstName, string lastName, string dob) 
        //     {
        //       //OfficeContext db = new OfficeContext() ;
        //     Employees em = new Employees
        //     {
        //         FirstName = firstName,
        //         LastName = lastName,
        //         Dob = DateTime.Parse(dob)
        //     };
        //     db.Employees.Add(em);
        //     db.SaveChanges();

        //     return RedirectToAction("EmployeeList");
        //  }

        //    public IActionResult Create(Employees emp) 
        //     {
                      
        //         db.Employees.Add(emp);
        //         db.SaveChanges();

        //         return RedirectToAction("EmployeeList");
        //     }

        public IActionResult Create (EmployeeViewModel employeeViewModel) {
            Employees employee = new Employees {
                FirstName = employeeViewModel.FirstName,
                LastName = employeeViewModel.LastName,
                Dob = employeeViewModel.Dob,
                DepartmentId = employeeViewModel.DepartmentId
            };
 
            db.Employees.Add (employee);
            db.SaveChanges ();
 
            return RedirectToAction ("List");
 
        }

        //  public IActionResult EmployeeList() 
        //  {
        //      var employees = db.Employees.ToList();
        //      return View(employees);
        //  }
        
        public IActionResult EmployeeList() 
         {
             var employees = db.Employees.Include(employees=>employees.Department).ToList(); //include does the task of join
             List<EmployeeViewModel> employeeViewModel = new List<EmployeeViewModel>();
             foreach(var e in employees)
             {
                 EmployeeViewModel employeeViewModel1 = new EmployeeViewModel{
                 FirstName = e.FirstName,
                 LastName = e.LastName,
                 Dob = e.Dob,
                 DepartmentName = (e?.Department?.Name)??"N/A"
                 };
             };
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