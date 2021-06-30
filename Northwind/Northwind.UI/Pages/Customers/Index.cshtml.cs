using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Northwind.Model.Data;
using Northwind.Model.Models;

namespace Northwind.UI.Pages.Customers
{
    public class IndexModel : PageModel
    {
        private readonly Northwind.Model.Data.NorthwindDbContext _context;

        public IndexModel(Northwind.Model.Data.NorthwindDbContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; }

        public async Task OnGetAsync()
        {
            Customer = await _context.Customers.ToListAsync();
        }
    }
}
