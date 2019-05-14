using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using XR_Wards.Models;
using XR_Wards.CommonTypes;

namespace XR_Wards.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View(new Registration() {
                FirstName = "Test",
                LastName = "blah"
            });
        }

        [HttpPost]
        public IActionResult PostRegistration(Registration register) 
        {
            if(ModelState.IsValid) {
                return Ok("Valid");
            }

            return Ok();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
