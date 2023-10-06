using InvoiceManagerMVC.Models.Domains;
using System.Collections.Generic;
using System.Linq;

namespace InvoiceManagerMVC.Models.Repositories
{
    public class ClientRepository
    {
        public List<Client> GetClient(string userId)
        {
            using (var context = new ApplicationDbContext())
            {
                return context.Clients.Where(x => x.UserId == userId).ToList();
            }
        }
    }
}