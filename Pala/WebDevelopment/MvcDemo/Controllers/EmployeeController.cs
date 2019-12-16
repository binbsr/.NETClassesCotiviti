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
        [HttpGet]
        public IActionResult Create()
        {
             OfficeContext db = new OfficeContext();
            var departments =db.Departments.Select(X=> new {X.Id,X.Name}).ToList();
            EmployeeViewModel employeeViewModel = new EmployeeViewModel()
            {
                DD_Departments = new  SelectList(departments,"Id","Name")
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
             //   FirstName=FirstName,
              //  LastName=LastName,
               // DOB = DateTime.Parse(Dob)
           // };
            db.Employees.Add(employee);
            db.SaveChanges();

            return RedirectToAction("List");

        }
        public IActionResult List()
        {
            OfficeContext db = new OfficeContext();
           var employees = db.Employees.Include(e=>e.Department).ToList();///Include department id and name (join)
           List<EmployeeViewModel> employeeViewModels = new List<EmployeeViewModel>();
           foreach(var employee in employees)
           {
               EmployeeViewModel employeeViewModel = new EmployeeViewModel()
               {
                FirstName=employee.FirstName,
                LastName=employee.LastName,
                DOB=employee.DOB,
                DepartmentName = (employee?.Department?.Name) ?? "N/A"
               };
           employeeViewModels.Add(employeeViewModel);
           }
           return View(employeeViewModels);
        }
        
        public IActionResult Details(int id)
        {
           using(OfficeContext officeContext = new OfficeContext())
           {
               return View(officeContext.Employees.Where(X=>X.Id==id).FirstOrDefault());
           }
         
        }

        //get:/Employee/Edit
        public IActionResult Edit(int id)
        {
              using(OfficeContext officeContext = new OfficeContext())
           {
               return View(officeContext.Employees.Where(X=>X.Id==id).FirstOrDefault());
           }

        }
        [HttpPost]
        public IActionResult Edit(int id,Employee employee)
        {
            using (OfficeContext officeContext = new OfficeContext())
            {
                officeContext.Entry(employee).State = EntityState.Modified;
                officeContext.SaveChanges();
                //Add udate logic
                return RedirectToAction("List");
            }

        }

    }

}