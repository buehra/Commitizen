using Microsoft.EntityFrameworkCore;
using Commitizen.Core.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Commitizen.Data.Configurations
{
    class ChangeTypeConfiguration : IEntityTypeConfiguration<ChangeType>
    {
        public void Configure(EntityTypeBuilder<ChangeType> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name).IsRequired();

            builder.Property(c => c.Description).IsRequired();

            builder.Property(c => c.Active).HasDefaultValue(true);

            builder.ToTable("ChangeType");
        }
    }
}
