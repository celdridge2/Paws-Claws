using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.IO;

using PawsClaws.Data;
using PawsClaws.Models;
using Microsoft.AspNetCore.Hosting;
using System.Collections;

namespace PawsClaws.Pages.Pets
{
    public class DeleteModel : PageModel
    {
        private readonly PawsClaws.Data.PawsClawsContext _context;
        private readonly IHostingEnvironment _environment;
        public readonly ArrayList Images = new ArrayList();

        public DeleteModel(PawsClaws.Data.PawsClawsContext context, IHostingEnvironment ihe)
        {
            _context = context;
            _environment = ihe;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Pet = await _context.Pet.FindAsync(id);

            if (Pet != null)
            {
                _context.Pet.Remove(Pet);

                string ImgDirPath = Path.Combine(_environment.WebRootPath, "images", Pet.ID + "/");
                DirectoryInfo ImgDir = new DirectoryInfo(ImgDirPath);
                foreach (FileInfo file in ImgDir.EnumerateFiles())
                {
                    file.Delete();
                }
                ImgDir.Delete();

                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index", new { CurrentPage = 1 });
        }

        private void GetPetImages()
        {
            DirectoryInfo ImgDir = new DirectoryInfo(Path.Combine(_environment.WebRootPath, "images", Pet.ID + "/"));
            foreach (FileInfo f in ImgDir.EnumerateFiles())
            {
                if (!f.FullName.Contains("thumb"))
                    Images.Add(f.FullName);
            }
        }
    }
}
