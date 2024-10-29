using RentCarClient.Models.Requests;
using RentCarClient.Models.Results;

namespace RentCarClient.Services
{
    public interface IAuth
    {
        Task<ApiResponse<string>> RegisterCustomer(RegisterCustomerRequest request);
    }
}
