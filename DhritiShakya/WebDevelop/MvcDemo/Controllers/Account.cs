using Microsoft.AspNetCore.Mvc;
namespace MvcDemo.Controllers
{
   public class AccountController:Controller
   {
      public IActionResult Register()=> View();
   } 
}