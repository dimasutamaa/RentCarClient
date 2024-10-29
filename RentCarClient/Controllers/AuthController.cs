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
    }
}
