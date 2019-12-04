using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.IO;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;

using PawsClaws.Data;
using PawsClaws.Models;


namespace PawsClaws.Pages.Pets
{
    public class CreateModel : PageModel
    {
        private readonly PawsClaws.Data.PawsClawsContext _context;
        private readonly IHostingEnvironment _environment;

        public CreateModel(PawsClaws.Data.PawsClawsContext context, IHostingEnvironment ihe)
        {
            _context = context;
            _environment = ihe;
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

            var newFileName = string.Empty;

            if (HttpContext.Request.Form.Files != null)
            {
                var fileName = "";

                var files = HttpContext.Request.Form.Files;
                int i = 0;

                var currentDir = Path.Combine(_environment.WebRootPath, "images", "" + Pet.ID);
                Directory.CreateDirectory(currentDir);

                foreach (var file in files)
                {
                    if (file.Length > 0)
                    {
                        fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                        var FileExtension = Path.GetExtension(fileName);

                        newFileName = i++ + FileExtension;

                        fileName = currentDir + $@"\{newFileName}";

                        using (FileStream fs = System.IO.File.Create(fileName))
                        {
                            file.CopyTo(fs);
                            fs.Flush();
                        }
                    }
                }

                // Create thumbnail
                using (Image img = Image.Load(currentDir + "/0.jpg"))
                {
                    img.Mutate(x => x.Resize(200, 125));
                    img.Save(currentDir + "/thumb.jpg");
                }
            }

            await _context.SaveChangesAsync();
            return RedirectToPage("./Index", new { CurrentPage = 1 });
        }
    }
}