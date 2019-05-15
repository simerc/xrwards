using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using XR_Wards.CommonTypes;

namespace XR_Wards.Models
{
    public class RegisterModel : PageModel
    {
        public string Message { get; set; }

        public Registration Registration { get; set; }

        public void OnGet()
        {
            Message = "First load";
        }

        public void OnPost()
        {
            Registration = new Registration()
            {
                FirstName = Request.Form[nameof(Registration.FirstName)],
                LastName = Request.Form[nameof(Registration.LastName)],
                Email = Request.Form[nameof(Registration.Email)],
                ConfirmStoringEmail = Request.Form[nameof(Registration.ConfirmStoringEmail)] == "true"
            };
        }
    }
}
