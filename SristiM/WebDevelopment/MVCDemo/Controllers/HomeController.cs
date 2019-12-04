using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCDemo.Models;

namespace MVCDemo.Controllers {
    public class HomeController : Controller {
        //web page will be controllername\action i.e. Home\Index
        public IActionResult Index () {
            return View ();
        }

        public IActionResult Gallery () => View (); //inline method so using lamda expression

    }
}