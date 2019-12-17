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
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
namespace MvcDemo.Controllers
{

    public class DepartmentController : Controller
    {
        private readonly IOfficeContext db;
        private readonly IMyLogger _logger;
        public DepartmentController(IOfficeContext context, IMyLogger logger)
        {
            db = context;
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Department department)//Binding varables from form
        {
            OfficeContext db = new OfficeContext();


            //Employee em = new Employee
            //{
            //   FirstName=FirstName,
            //  LastName=LastName,
            // DOB = DateTime.Parse(Dob)
            // };
            db.Departments.Add(department);
            db.SaveChanges();
            _logger.LogToConsole("Department Created");
            return RedirectToAction("List");

        }
        public IActionResult List()
        {

            var Departments = db.Departments.ToList();
            _logger.LogToConsole("Department, Department List Fetched");
            return View(Departments);

        }
        public IActionResult Details(int id)
        {
            using (OfficeContext officeContext = new OfficeContext())
            {
                return View(officeContext.Departments.Where(X => X.Id == id).FirstOrDefault());
            }

        }

        //get:/Employee/Edit
        public IActionResult Edit(int id)
        {
            using (OfficeContext officeContext = new OfficeContext())
            {
                return View(officeContext.Departments.Where(X => X.Id == id).FirstOrDefault());
            }

        }
        [HttpPost]
        public IActionResult Edit(int id, Department department)
        {
            using (OfficeContext officeContext = new OfficeContext())
            {
                officeContext.Entry(department).State = EntityState.Modified;
                officeContext.SaveChanges();
                //Add udate logic
                return RedirectToAction("List");
            }
        }

    }

}