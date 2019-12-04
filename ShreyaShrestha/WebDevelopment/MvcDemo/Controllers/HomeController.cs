using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcDemo.Models;

namespace MvcDemo.Controllers
{
    public class HomeController : Controller
    {
        // private readonly ILogger<HomeController> _logger;

        // public HomeController(ILogger<HomeController> logger)
        // {
        //     _logger = logger;
        // }

        public IActionResult Index() //root folder Home/Index if we see in the view folder as this function is returning View,
        // there we can see Home folder under which there is Index.cshtml file
        //cshtml = C sharp HTML, where we can write both c# and HTML code
        {
            return View();
        }

        // public IActionResult Privacy()
        // {
        //     return View();
        // } //also Delete Privacy folder in View Folder

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        // }

        public IActionResult Gallery() => View();
       
    }
}
