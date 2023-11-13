using Microsoft.EntityFrameworkCore;

namespace MySqlTest.Data;

public class DatabaseContext : DbContext
{
    public DbSet<AuthUser> AuthUsers { get; set; } = null!;
    
    public DatabaseContext()
    {
        
    }

    public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
    {
        
    }
}