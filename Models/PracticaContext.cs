using Microsoft.EntityFrameworkCore;

namespace PC04.Models
{
    public class PracticaContext : DbContext
    {
        public DbSet<Fail> TFail { get; set; }
    public PracticaContext(DbContextOptions dco) : base(dco){}

    }
}