using Microsoft.EntityFrameworkCore;

namespace Kolokvijum.Context
{
    public class MVCContext:DbContext
    {
        
            public MVCContext(DbContextOptions<MVCContext> options) : base(options)
            {

            }
            public DbSet<Predmet> Predmeti { get; set; }
            public DbSet<Profesor> Profesori { get; set; }
    }
    
}

