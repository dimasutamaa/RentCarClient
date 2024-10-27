using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RentCarClient.Controllers
{
    public class RentalController : Controller
    {
        // GET: RentalController
        public IActionResult History()
        {
            return View();
        }
    }
}
