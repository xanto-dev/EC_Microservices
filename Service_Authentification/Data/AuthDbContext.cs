using Microsoft.EntityFrameworkCore;
using Service_Authentification.Models;


namespace Service_Authentification.Data
{
    public class AuthDbContext : DbContext
    {
        public DbSet<TokenRecord> TokenRecords { get; set; }
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
            { }

    }
}
