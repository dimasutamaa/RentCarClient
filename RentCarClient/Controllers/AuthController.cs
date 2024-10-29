using Microsoft.AspNetCore.Mvc;
using RentCarClient.Models.Requests;
using RentCarClient.Services;

namespace RentCarClient.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuth _authApi;

        public AuthController(IAuth authApi)
        {
            _authApi = authApi;
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public async Task<IActionResult> RegisterCustomer([FromBody] RegisterCustomerRequest request)
        {
            var result = await _authApi.RegisterCustomer(request);
            return Json(result);
        }

        public async Task<IActionResult> LoginCustomer([FromBody] LoginCustomerRequest request)
        {
            var result = await _authApi.LoginCustomer(request);

            if (result.StatusCode == 200)
            {
                HttpContext.Session.SetString("CustomerEmail", request.email);
                return Ok(new { statusCode = 200, message = "Customer successfully logged in" });
            }
            else
            {
                return BadRequest(new { statusCode = result.StatusCode, message = "Invalid credentials" });
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
