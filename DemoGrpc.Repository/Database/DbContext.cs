using DemoGrpc.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DemoGrpc.Repository.Database
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext(DbContextOptions<DemoDbContext> options)
            : base(options)
        { }

        public DbSet<Country> Country { get; set; }
    }
}