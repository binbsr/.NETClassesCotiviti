using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCDemo.Data;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        DataContext dbcon = new DataContext();
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(string FirstName, string LastName, string DOB)
        {

            Employee emp = new Employee()
            {
                FirstName = FirstName,
                LastName = LastName,
                DOB = DateTime.Parse(DOB)
            };
            dbcon.Employees.Add(emp);
            dbcon.SaveChanges();
            return RedirectToAction("List");

        }
        [HttpGet]

        public IActionResult List()
        {
            var emps = dbcon.Employees.ToList();
            return View(emps);

        }
        public IActionResult Edit(int id)
        {
            Employee employee = dbcon.Employees.Where(x => x.Id == id).FirstOrDefault();            
            return View(employee);

        }
        [HttpPost]
        public IActionResult Edit(int id, string FirstName, string LastName, string Dob)
        {
            var employee = dbcon.Employees.Where(x => x.Id == id).FirstOrDefault();
            employee.FirstName = FirstName;
            employee.LastName = LastName;
            employee.DOB =  DateTime.Parse(Dob);
            dbcon.SaveChanges();         
            return RedirectToAction("List");     
        }
        public IActionResult Delete(int id)
        {
            var empToDel = dbcon.Employees.Where(x =>x.Id == id).FirstOrDefault();
            dbcon.Remove(empToDel);
            dbcon.SaveChanges();
            return RedirectToAction("List");
        }
    }
}