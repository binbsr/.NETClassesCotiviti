using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using MvcDemo.Data;
using MvcDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace MvcDemo.Controllers{

    public class DepartmentController: Controller
    {
            private readonly IOfficeContext db ;
            private readonly ILogger  _logger;
        public DepartmentController(IOfficeContext context,ILogger logger)
        {
                db=context;
                _logger=logger;
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Department department)//Binding varables from form
        {
            
            //Employee em = new Employee
            //{
            //  FirstName=FirstName,
             //   LastName=LastName,
              //  DOB = DateTime.Parse(Dob)
            //};
            db.Departments.Add(department);
            db.SaveChanges();

            return RedirectToAction("List");

        }
        public IActionResult List()
        {
            OfficeContext db = new OfficeContext();
           var department = db.Departments.ToList();
           return View(department);

        }
       

       [HttpGet]
        public IActionResult Edit(int id)//Binding varables from form
        {
            OfficeContext db = new OfficeContext();
                    
            var employee = db.Employees.Find(id);
            
           return View(employee);
            
        }

        [HttpPost]
        public IActionResult Edit(Employee emp)//Binding varables from form
        {
            OfficeContext db = new OfficeContext();
                    
            var employee = db.Employees.Find(emp.Id);
            employee.FirstName=emp.FirstName;
            employee.LastName=emp.LastName;
            employee.DOB=emp.DOB;                  
            db.SaveChanges();

            return RedirectToAction("List");

        }
    }

}