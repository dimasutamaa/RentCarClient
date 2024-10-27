using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using RentCarClient.Models.Results;

namespace RentCarClient.Services
{
    public interface ICar
    {
        Task<ApiResponse<IEnumerable<GetCarResult>>> GetCar();
        //Task<ApiResponse<GetCarResult>> FindCar(string car_id);
    }
}
