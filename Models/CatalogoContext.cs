using Microsoft.EntityFrameworkCore;

namespace FamiliaRojanAmaralApi.Models; 

public class CatalogoContext : DbContext
{
    public CatalogoContext(DbContextOptions<CatalogoContext> options)
        : base(options)
    {
    }

    public DbSet<CatalogoItem> CatalogoItems { get; set; } = null!;
}