﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Test.Data;
using Test.Models;

namespace Test.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly Test.Data.TestContext _context;

        public CreateModel(Test.Data.TestContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public movie movie { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.movie.Add(movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
