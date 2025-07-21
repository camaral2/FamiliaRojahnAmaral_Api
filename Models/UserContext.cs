using Microsoft.EntityFrameworkCore;

namespace FamiliaRojanAmaralApi.Models; 

public class UserContext : DbContext
{
    public UserContext(DbContextOptions<UserContext> options)
        : base(options)
    {
    }

    public DbSet<User> user { get; set; } = null!;
}