
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceManagerMVC.Models.Domains
{
    public class Client
    {
        public Client()
        {
            Invoices = new Collection<Invoice>();
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [ForeignKey("Address")]
        public int AddresId { get; set; }
        public string Email { get; set; }
        [Required]
        [ForeignKey("User")]
        public string UserId { get; set; }

        public ICollection<Invoice> Invoices { get; set; }
        public Address Address { get; set; }
        public ApplicationUser User { get; set; }
    }
}