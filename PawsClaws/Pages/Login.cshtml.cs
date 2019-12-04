using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PawsClaws.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public LoginData loginData { get; set; }

        private string TrueHash = "49CUNrfTtTKX1YGsb3pIj550JVAun08s4wFNjCRbAfg=";

        public async Task<RedirectToPageResult> OnPostAsync()
        {
            loginData.HashPass();
            if (ModelState.IsValid)
            {
                var isValid = (loginData.Username == "NPHEmployees" && loginData.PasswordHash == TrueHash);
                if (!isValid)
                {
                    ModelState.AddModelError("", "Username or Password is invalid!");
                    return RedirectToPage("Login");
                }
                var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme, ClaimTypes.Name, ClaimTypes.Role);
                identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, loginData.Username));
                identity.AddClaim(new Claim(ClaimTypes.Name, loginData.Username));
                var principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, new AuthenticationProperties { IsPersistent = loginData.RememberMe });
                return RedirectToPage("Pets/Index");
            }
            else
            {
                ModelState.AddModelError("", "Username and Password cannot be left blank.");
                return RedirectToPage("Login");
            }
        }

        public class LoginData
        {
            [Required]
            public string Username { get; set; }

            [Required, DataType(DataType.Password)]
            public string Password { get; set; }

            public string PasswordHash { get; private set; }

            public bool RememberMe { get; set; }

            public void HashPass()
            {
                PasswordHash = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                    password: Password,
                    salt: Convert.FromBase64String("ET7MYwwotuHk1+wZOeycog=="),
                    prf: KeyDerivationPrf.HMACSHA1,
                    iterationCount: 10000,
                    numBytesRequested: 256 / 8));
            }
        }
    }
}