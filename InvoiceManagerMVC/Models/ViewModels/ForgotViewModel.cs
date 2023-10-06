using System.ComponentModel.DataAnnotations;

namespace InvoiceManagerMVC.Models
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
