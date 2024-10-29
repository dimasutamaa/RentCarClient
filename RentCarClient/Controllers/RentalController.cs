using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RentCarClient.Controllers
{
    public class RentalController : Controller
    {
        // GET: RentalController
        public IActionResult History()
        {
            var customerEmail = HttpContext.Session.GetString("CustomerEmail");

            if (string.IsNullOrEmpty(customerEmail))
            {
                return RedirectToAction("Login", "Auth");
            }

            ViewData["CustomerEmail"] = customerEmail;

            return View();
        }
    }
}
