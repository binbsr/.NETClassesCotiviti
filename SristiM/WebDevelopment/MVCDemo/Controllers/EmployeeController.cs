using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCDemo.Data;
using MVCDemo.Models;

namespace MVCDemo.Controllers {
    public class EmployeeController : Controller {
        OfficeContext db = new OfficeContext ();
        // public IActionResult Create () {
        //     return View ();
        // }

        [HttpPost]
        // public IActionResult Create (int id,string fname, string lname, string DOB) {

        //     Employee em = new Employee {
        //         Id=id,
        //         FirstName = fname,
        //         LastName = lname,
        //         DOB = DateTime.Parse(DOB)
        //     };
        //     db.Employees.Add (em);
        //     db.SaveChanges ();

        //     return RedirectToAction ("List");

        // }
        public IActionResult Create (Employee emp) {

            db.Employees.Add (emp);
            db.SaveChanges ();

            return RedirectToAction ("List");

        }

        [HttpGet]
        public IActionResult Create () {
            var departments = db.Departments.Select (x => new { x.Id, x.Name }).ToList ();
            EmployeeViewModel employeeViewModel = new EmployeeViewModel { DD_Department = new SelectList(departments, "Id", "Name") };
            return View (employeeViewModel);
        }

        [HttpGet]
        //var dept1 = db.Department.Where (x => x.ID == 22).FirstOrDefault ();
        // public IActionResult Update (int? id, string fname, string lname, string DOB) {
        //     var empToUpdate = db.Employees.Where (x => x.Id == id).FirstOrDefault ();
        //     empToUpdate.FirstName = fname;
        //     empToUpdate.LastName = lname;
        //     empToUpdate.DOB = DateTime.Parse (DOB);

        public IActionResult Update (int? id) {
            var empToUpdate = db.Employees.Where (x => x.Id == id).FirstOrDefault ();
            return View (empToUpdate);
        }

        [HttpPost]
        //Model binding
        public IActionResult Update (Employee emp) {
            //db.Entry(emp).State=EntityState.Modified;
            var Employees = emp;

            db.SaveChanges ();
            return RedirectToAction ("List");

        }

        public IActionResult List () {
            var employees = db.Employees.ToList ();
            return View (employees);
        }

    }
}