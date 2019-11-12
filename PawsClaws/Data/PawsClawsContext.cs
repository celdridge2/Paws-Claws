using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PawsClaws.Models;

namespace PawsClaws.Data
{
    public class PawsClawsContext : DbContext
    {
        public PawsClawsContext (DbContextOptions<PawsClawsContext> options)
            : base(options)
        {
        }

        public DbSet<PawsClaws.Models.Pet> Pet { get; set; }
    }
}
