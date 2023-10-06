using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace InvoiceManagerMVC.Models.Domains
{
    public class Product
    {
        public Product()
        {
                InvoicePositions = new Collection<InvoicePosition>();
        }
        public int Id { get; set; }
        [Required]
        [Display(Name = "Nazwa")]
        public string Name { get; set; }
        [Display(Name = "Wartość")]
        public decimal Value { get; set; }

        //public int Vat { get; set; }    
        //public DataType ExpireDate { get; set; }
        public ICollection<InvoicePosition> InvoicePositions { get; set;}
    }
}