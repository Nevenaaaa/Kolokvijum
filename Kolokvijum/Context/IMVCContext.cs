using Microsoft.EntityFrameworkCore;

namespace Kolokvijum.Context
{
    public interface IMVCContext
    {
        DbSet<Predmet> Predmeti { get; set; }
        DbSet<Profesor> Profesori { get; set; }
    }
}