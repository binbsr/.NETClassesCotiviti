using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MvcDemo.Data;
using MvcDemo.Models;


public class DepartmentsController:Controller
        {
            OfficeContext db=new OfficeContext();
            public IActionResult DepartmentLIst()
            {
                var Departments=db.Department.ToList();
                return View(Departments);
            }
            
            public IActionResult Create()
            {                
                return View();
            }          
           
        }





        


