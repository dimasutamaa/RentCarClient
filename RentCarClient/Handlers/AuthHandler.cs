using RentCarClient.Models.Requests;
using RentCarClient.Models.Results;
using RentCarClient.Services;

namespace RentCarClient.Handlers
{
    public class AuthHandler : IAuth
    {
        private readonly IConfiguration _configuration;
        private readonly string baseUrl = "";
        private HttpClient httpClient = new HttpClient();

        public AuthHandler(IConfiguration configuration)
        {
            _configuration = configuration;
            baseUrl = _configuration["apiEndpoint"];
        }

        public async Task<ApiResponse<string>> RegisterCustomer(RegisterCustomerRequest request)
        {
            if (request == null)
            {
                return new ApiResponse<string>()
                {
                    StatusCode = 400,
                    Data = "Bad Request"
                };
            }

            string endpoint = baseUrl + "Auth/register/";
            var response = await httpClient.PostAsJsonAsync(endpoint, request);
            var apiResponse = await response.Content.ReadFromJsonAsync<ApiResponse<string>>();

            return apiResponse;
        }

        public async Task<ApiResponse<string>> LoginCustomer(LoginCustomerRequest request)
        {
            if (request == null)
            {
                return new ApiResponse<string>()
                {
                    StatusCode = 400,
                    Data = "Bad Request"
                };
            }

            string endpoint = baseUrl + "Auth/login/";
            var response = await httpClient.PostAsJsonAsync(endpoint, request);

            if (!response.IsSuccessStatusCode)
            {
                return new ApiResponse<string>()
                {
                    StatusCode = (int)response.StatusCode,
                    Data = "Login failed"
                };
            }

            var apiResponse = await response.Content.ReadFromJsonAsync<ApiResponse<string>>();
            return apiResponse;
        }
    }
}
