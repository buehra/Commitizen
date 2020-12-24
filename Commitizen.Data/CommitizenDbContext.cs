using Commitizen.Core.Models;
using Commitizen.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Commitizen.Data
{
    public class CommitizenDbContext : DbContext
    {
        public DbSet<ChangeType> ChangeTypes { get; set; }
        public DbSet<Scope> Scopes { get; set; }

        public CommitizenDbContext(DbContextOptions<CommitizenDbContext> options): base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .ApplyConfiguration(new ChangeTypeConfiguration());

            builder
                .ApplyConfiguration(new ScopeConfiguration());
        }

    }
}
