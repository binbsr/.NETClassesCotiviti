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
    public class AccountsController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
            
        

       
}
