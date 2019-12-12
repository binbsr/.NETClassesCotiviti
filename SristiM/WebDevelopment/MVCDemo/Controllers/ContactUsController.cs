using Microsoft.AspNetCore.Mvc;

namespace MVCDemo.Controllers {
    public class ContactUsController : Controller {
        public IActionResult ContactUs()=>View();

    }

}