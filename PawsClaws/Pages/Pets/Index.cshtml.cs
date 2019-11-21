using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PawsClaws.Data;
using PawsClaws.Models;

namespace PawsClaws.Pages.Pets
{
    public class IndexModel : PageModel
    {
        private readonly PawsClaws.Data.PawsClawsContext _context;

        public IndexModel(PawsClaws.Data.PawsClawsContext context)
        {
            _context = context;
        }

        public IList<Pet> Pet { get;set; }

        [BindProperty(SupportsGet = true)]
        public string Species { get; set; }
        

        public async Task OnGetAsync()
        {
            var pets = from m in _context.Pet select m;
            if (!string.IsNullOrEmpty(Species))
                pets = pets.Where(s => s.Species.Equals(Species));
            
            Pet = await pets.ToListAsync();
        }
    }
}
