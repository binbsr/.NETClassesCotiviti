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
    public class AccountController : Controller
    {
       public IActionResult Register() => View();
       
    }
}
