using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
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

        [BindProperty(SupportsGet = true)]
        public int CurrentPage { get; set; } = 1;
        public int Count { get; set; }
        public int PageSize { get; set; } = 12;
        public int TotalPages => (int)Math.Ceiling(decimal.Divide(Count, PageSize));
        public int FirstPage => 1;
        public int LastPage => TotalPages;
        public int PrevPage => Math.Max(CurrentPage - 1, FirstPage);
        public int NextPage => Math.Min(CurrentPage + 1, LastPage);
        [BindProperty(SupportsGet = true)]
        public string Species { get; set; }
        public IList<Pet> Pet { get; set; }


        public IndexModel(PawsClaws.Data.PawsClawsContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            var skip = (CurrentPage - 1) * PageSize;
            var take = PageSize;

            var pets = from m in _context.Pet select m;
            if (!string.IsNullOrEmpty(Species))
                pets = pets.Where(s => s.Species.Equals(Species));

            var PetTask = pets.Skip(skip).Take(take).ToListAsync();
            var CountTask = pets.CountAsync();
            
            Pet = await PetTask;
            Count = await CountTask;
        }
        
    }
}
