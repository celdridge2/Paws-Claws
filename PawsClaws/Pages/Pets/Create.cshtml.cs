using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PawsClaws.Data;
using PawsClaws.Models;

namespace PawsClaws.Pages.Pets
{
    public class CreateModel : PageModel
    {
        private readonly PawsClaws.Data.PawsClawsContext _context;

        public CreateModel(PawsClaws.Data.PawsClawsContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Pet Pet { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Pet.Add(Pet);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}