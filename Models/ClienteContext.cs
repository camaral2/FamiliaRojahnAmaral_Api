using Microsoft.EntityFrameworkCore;

namespace FamiliaRojanAmaralApi.Models; 

public class ClienteContext : DbContext
{
    public ClienteContext(DbContextOptions<ClienteContext> options)
        : base(options)
    {
    }

    public DbSet<Cliente> Cliente { get; set; } = null!;
}