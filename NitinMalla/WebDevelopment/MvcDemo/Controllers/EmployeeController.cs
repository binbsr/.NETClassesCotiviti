using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
             return View(); 
          } 

        [HttpPost]
          public IActionResult Create(string FirstName, string LastName, string Dob)
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