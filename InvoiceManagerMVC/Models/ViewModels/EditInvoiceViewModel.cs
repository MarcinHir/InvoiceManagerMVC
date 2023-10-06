using InvoiceManagerMVC.Models.Domains;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace InvoiceManagerMVC.Models.ViewModels
{
    public class EditInvoiceViewModel
    {
        public Invoice Invoice { get; set; }
        public List<Client> Clients { get; set; }
        public List<MethodOfPayment> MethodOfPayments { get; set; }
        public string Heading { get; set; }
    }
}