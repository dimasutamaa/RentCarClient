﻿using System.ComponentModel.DataAnnotations;

namespace RentCarClient.Models.Requests
{
    public class LoginCustomerRequest
    {
        [Required]
        public string email { get; set; }

        [Required]
        public string password { get; set; }
    }
}
