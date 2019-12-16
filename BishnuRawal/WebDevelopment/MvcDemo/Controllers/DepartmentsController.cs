using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MvcDemo.Models;

namespace MvcDemo.Controllers
{
    public class DepartmentsController : Controller
    {
        private readonly IOfficeContext db;
        private readonly IMyLogger _logger;

        public DepartmentsController(IOfficeContext context, IMyLogger logger)
        {
            db = context;
            _logger = logger;
        }

        public IActionResult List()
        {         
            var departments = db.Departments.ToList();
            _logger.LogToConsole("Departments list fetched");
            return View(departments);
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Department department)
        {
            db.Departments.Add(department);
            db.SaveChanges();
            _logger.LogToConsole("Department Created.");
            
            return RedirectToAction("List");
        }
    }
}