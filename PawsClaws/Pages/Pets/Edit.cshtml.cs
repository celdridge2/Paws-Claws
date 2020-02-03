using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Web;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using PawsClaws.Data;
using PawsClaws.Models;

namespace PawsClaws.Pages.Pets
{
    public class EditModel : PageModel
    {
        private readonly PawsClaws.Data.PawsClawsContext _context;
        private readonly IHostingEnvironment _environment;
        public ArrayList Images = new ArrayList();

        public EditModel(PawsClaws.Data.PawsClawsContext context, IHostingEnvironment ihe)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Pet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PetExists(Pet.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PetExists(int id)
        {
            return _context.Pet.Any(e => e.ID == id);
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

        public async Task<IActionResult> OnPostDeleteImage(String filename)
        {
            FileInfo img = new FileInfo(Path.Combine(_environment.WebRootPath, filename));
            img.Delete();
            foreach (String x in Images)
                if (x.Contains(filename))
                    Images.Remove(x);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index", new { CurrentPage = 1});
        }
    }
}
