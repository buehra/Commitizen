using Commitizen.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Commitizen.Data.Configurations
{
    class ScopeConfiguration : IEntityTypeConfiguration<Scope>
    {
        public void Configure(EntityTypeBuilder<Scope> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Name).IsRequired();

            builder.Property(s => s.Description).IsRequired();

            builder.Property(s => s.Active).HasDefaultValue(true);

            builder.ToTable("Scope");
        }
    }
}
