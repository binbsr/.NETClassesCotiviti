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
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcDemo.Controllers{

    public class EmployeeController: Controller
      {

          OfficeContext db=new OfficeContext();
        [HttpGet]
        public IActionResult Create()
        {
            var departments= db.Departments.Select(x => new{x.Id,x.Name}).ToList();
            EmployeeViewModel employeeViewModel=new EmployeeViewModel
            {
                DD_Departments=new SelectList(departments,"Id","Name")
            };

            return View(employeeViewModel);
        }
        [HttpPost]
        public IActionResult Create(EmployeeViewModel employeeViewModel)//Binding varables from form
        {
            OfficeContext db = new OfficeContext();
            Employee employee = new Employee
            {
                    FirstName=employeeViewModel.FirstName,
                    LastName=employeeViewModel.LastName,
                    DOB=employeeViewModel.DOB,
                    DepartmentId=employeeViewModel.DepartmentId

            };
            //Employee em = new Employee
            //{
            //  FirstName=FirstName,
             //   LastName=LastName,
              //  DOB = DateTime.Parse(Dob)
            //};
            db.Employees.Add(employee);
            db.SaveChanges();

            return RedirectToAction("List");

        }
        public IActionResult List()
        {
            OfficeContext db = new OfficeContext();
           var employees = db.Employees.Include(e=>e.Department).ToList(); // join internally
           List<EmployeeViewModel>employeeViewModels=new List<EmployeeViewModel>();
           foreach(var employee in employees)
           {
               EmployeeViewModel employeeViewModel=new EmployeeViewModel
               {
                   FirstName=employee.FirstName,
                   LastName=employee.LastName,
                   DOB=employee.DOB,
                   DepartmentName=(employee?.Department?.Name)??" NA"

               };
             employeeViewModels.Add(employeeViewModel);
           }
           return View(employeeViewModels);

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