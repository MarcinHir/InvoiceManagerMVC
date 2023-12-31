﻿using System.ComponentModel.DataAnnotations;

namespace InvoiceManagerMVC.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
