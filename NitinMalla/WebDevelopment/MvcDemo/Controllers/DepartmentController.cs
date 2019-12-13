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
    public class DepartmentController : Controller
    {
       OfficeContext db = new OfficeContext();
        [HttpGet]
          public IActionResult Create()
          {
             return View(); 
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
          public IActionResult Create(Department department)
          {
             
             db.Departments.Add(department);
             db.SaveChanges();
             
             return RedirectToAction("List");
          }

          public IActionResult List()
          {
             var departments = db.Departments.ToList();
             return View(departments); 
          } 

          public IActionResult Update(int Id)
          {
             var department = db.Departments.Where(x => x.Id == Id).FirstOrDefault();
             return View(department); 
          }

           [HttpPost]
          public IActionResult Update(int Id,string Name, string Location )
          {
             
           /* Employee updatedEmployee = (from e in db.Employees
                                        where e.Id == employee.Id
                                        select e).FirstOrDefault();
             updatedEmployee.FirstName = employee.FirstName;
             updatedEmployee.LastName = employee.LastName;
             updatedEmployee.DOB = employee.DOB;
*/
            var department = db.Departments.Where(x => x.Id == Id).FirstOrDefault();
            department.Name = Name;
            department.Location = Location;
            db.SaveChanges();         
            return RedirectToAction("List"); 

          }
     
    }

}