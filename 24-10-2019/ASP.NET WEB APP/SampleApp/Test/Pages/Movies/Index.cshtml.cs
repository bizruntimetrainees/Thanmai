using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Test.Data;
using Test.Models;

namespace Test.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly Test.Data.TestContext _context;

        public IndexModel(Test.Data.TestContext context)
        {
            _context = context;
        }

        public IList<movie> movie { get;set; }

        public async Task OnGetAsync()
        {
            movie = await _context.movie.ToListAsync();
        }
    }
}
