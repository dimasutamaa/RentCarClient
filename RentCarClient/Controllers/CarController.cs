using Microsoft.AspNetCore.Mvc;
using RentCarClient.Services;

namespace RentCarClient.Controllers
{
    public class CarController : Controller
    {
        private readonly ICar _carApi;

        public CarController(ICar carApi)
        {
            _carApi = carApi;
        }

        public IActionResult Details()
        {
            return View();
        }

        public async Task<IActionResult> GetCar()
        {
            var result = await _carApi.GetCar();
            return Json(result);
        }
    }
}
