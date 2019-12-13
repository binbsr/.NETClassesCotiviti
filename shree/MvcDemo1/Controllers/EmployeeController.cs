using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MvcDemo.Data;
using MvcDemo.Models;
using MvcDemo1.Models;


public class EmployeeController:Controller
        {
            OfficeContext db=new OfficeContext();
            public IActionResult EmployeeLIst()
            {
                var Employees=db.Employees.ToList();
                return View(Employees);
            }
            [HttpGet]
            public IActionResult Create()
            {
                var departments=db.Department.Select(x=>x.Name).ToList();
                EmployeeViewModel employeeViewModel = new EmployeeViewModel()
                {
                    DD_Departments=new Microsoft.AspNetCore.Mvc.Rendering.SelectList(departments, "Id", "Name")
                };
                return View(employeeViewModel);
            }

            [HttpPost]            
            public IActionResult Create(string FirstName, string LastName, string Dob)
            {
                Employee emp = new Employee()
                {
                    FirstName=FirstName,
                    LastName=LastName,
                    DOB=DateTime.Parse(Dob)
                };
                
                db.Employees.Add(emp);
                db.SaveChanges();
                return RedirectToAction("EmployeeLIst");
            }
            [HttpGet]
            public IActionResult Update(int empId)
            {
                var empRec=(from item in db.Employees
                            where item.Id==empId
                            select item).First();
                return View(empRec);
            }

            [HttpPost]
            public IActionResult Update(Employee empObj)
            {
                var empRec=(from item in db.Employees
                            where item.Id==empObj.Id
                            select item).First();
                empRec.FirstName=empObj.FirstName;
                empRec.LastName=empObj.LastName;
                empRec.DOB=empObj.DOB;
                db.SaveChanges();
                return RedirectToAction("EmployeeList");
            }    
        }





        


