using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TonyFood.Core;
using TonyFood.Data;

namespace TonyFood.Pages.R2
{
    public class IndexModel : PageModel
    {
        private readonly TonyFood.Data.TonyFoodDbContext _context;

        public IndexModel(TonyFood.Data.TonyFoodDbContext context)
        {
            _context = context;
        }

        public IList<Restaurant> Restaurant { get;set; }

        public async Task OnGetAsync()
        {
            Restaurant = await _context.Restaurants.ToListAsync();
        }
    }
}
