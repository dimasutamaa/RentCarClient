using System.ComponentModel.DataAnnotations;

namespace RentCarClient.Models.Requests
{
    public class RegisterCustomerRequest
    {
        [Required]
        public string email { get; set; }

        [Required]
        public string password { get; set; }

        [Required]
        public string re_password { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string phone_number { get; set; }

        [Required]
        public string address { get; set; }
    }
}
