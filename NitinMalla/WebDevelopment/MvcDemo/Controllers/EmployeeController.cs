using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
             var departments = db.Departments.Select(x => new{x.Id, x.Name}).ToList();
             EmployeeViewModel employeeViewModel = new EmployeeViewModel
             {
                DD_Departments = new SelectList(departments,"Id","Name")
             };
             return View(employeeViewModel); 
          } 

       
         /* public IActionResult Create(string FirstName, string LastName, string Dob)
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

          }*/

           [HttpPost]
          public IActionResult Create(Employee employee)
          {
             
            // Employee emp = new Employee
             //{
              //  FirstName=FirstName, 
               // LastName= LastName, 
                //DOB = DateTime.Parse(Dob)
             //};
             db.Employees.Add(employee);
             db.SaveChanges();
             
             return RedirectToAction("List");
          }

          public IActionResult List()
          {
             var employees = db.Employees.ToList();
             return View(employees); 
          } 

          public IActionResult Update(int Id)
          {
             var employee = db.Employees.Where(x => x.Id == Id).FirstOrDefault();
             return View(employee); 
          }

           [HttpPost]
          public IActionResult Update(int Id,string FirstName, string LastName, string Dob)
          {
             
           /* Employee updatedEmployee = (from e in db.Employees
                                        where e.Id == employee.Id
                                        select e).FirstOrDefault();
             updatedEmployee.FirstName = employee.FirstName;
             updatedEmployee.LastName = employee.LastName;
             updatedEmployee.DOB = employee.DOB;
*/
            var employee = db.Employees.Where(x => x.Id == Id).FirstOrDefault();
            employee.FirstName = FirstName;
            employee.LastName = LastName;
            employee.DOB =  DateTime.Parse(Dob);
            db.SaveChanges();         
            return RedirectToAction("List"); 

          }
     
    }

}