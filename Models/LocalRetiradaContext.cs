using Microsoft.EntityFrameworkCore;

namespace FamiliaRojanAmaralApi.Models; 

public class LocalRetiradaContext : DbContext
{
    public LocalRetiradaContext(DbContextOptions<LocalRetiradaContext> options)
        : base(options)
    {
    }

    public DbSet<LocalRetirada> LocalRetirada { get; set; } = null!;
}