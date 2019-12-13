using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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
        public IActionResult Create(EmployeeViewModel employeeViewModel)
        {
            Employee employee = new Employee 
            {
                FirstName = employeeViewModel.FirstName,
                LastName = employeeViewModel.LastName,
                DOB = employeeViewModel.DOB,
                DepartmentId = employeeViewModel.DepartmentId
            };

            db.Employees.Add(employee);
            db.SaveChanges();

            return RedirectToAction("List");
        }

        public IActionResult List()
        {
            var employees = db.Employees.Include(e => e.Department).ToList();
            List<EmployeeViewModel> employeeViewModels = new List<EmployeeViewModel>();
            
            foreach (var employee in employees)
            {
                EmployeeViewModel employeeViewModel = new EmployeeViewModel
                {
                    FirstName = employee.FirstName,
                    LastName = employee.LastName,
                    DOB = employee.DOB,
                    DepartmentName = (employee?.Department?.Name) ?? "N/A"
                };
                employeeViewModels.Add(employeeViewModel);
            }

            return View(employeeViewModels);
        }
    }
}