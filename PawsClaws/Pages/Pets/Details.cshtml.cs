using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PawsClaws.Data;
using PawsClaws.Models;
using System.Collections;

namespace PawsClaws.Pages.Pets
{
    public class DetailsModel : PageModel
    {
        private readonly PawsClaws.Data.PawsClawsContext _context;
        private readonly IHostingEnvironment _environment;
        public readonly ArrayList Images = new ArrayList();

        public DetailsModel(PawsClaws.Data.PawsClawsContext context, IHostingEnvironment ihe)
        {
            _context = context;
            _environment = ihe;
            
        }

        public Pet Pet { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Pet = await _context.Pet.FirstOrDefaultAsync(m => m.ID == id);

            if (Pet == null)
            {
                return NotFound();
            }
            GetPetImages();
            return Page();
        }

        private void GetPetImages()
        {
            DirectoryInfo ImgDir = new DirectoryInfo(Path.Combine(_environment.WebRootPath, "images", Pet.ID + "/"));
            foreach (FileInfo f in ImgDir.EnumerateFiles())
            {
                if(!f.FullName.Contains("thumb"))
                    Images.Add(f.FullName);
            }
        }
    }
}
