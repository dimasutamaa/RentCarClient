using Newtonsoft.Json;
using RentCarClient.Models.Results;
using RentCarClient.Services;

namespace RentCarClient.Handlers
{
    public class CarHandler : ICar
    {
        private readonly IConfiguration _configuration;
        private readonly string baseUrl = "";
        private HttpClient httpClient = new HttpClient();

        public CarHandler(IConfiguration configuration)
        {
            _configuration = configuration;
            baseUrl = _configuration["apiEndpoint"];
        }

        public async Task<ApiResponse<IEnumerable<GetCarResult>>> GetCar()
        {
            string endpoint = baseUrl + "Car";

            var carResult = new ApiResponse<IEnumerable<GetCarResult>>();

            var response = await httpClient.GetAsync(endpoint);

            string apiResponse = await response.Content.ReadAsStringAsync();

            if (!string.IsNullOrEmpty(apiResponse))
            {
                carResult = JsonConvert.DeserializeObject<ApiResponse<IEnumerable<GetCarResult>>>(apiResponse);
            }

            return carResult;
        }
    }
}
