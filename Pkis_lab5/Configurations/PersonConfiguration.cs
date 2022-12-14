using Lab5.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lab5.Configurations;

internal sealed class GoodsConfiguration : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.Property(r => r.FirstName).IsRequired();
        builder.Property(r => r.LastName).IsRequired();
        builder.Property(r => r.LastName).IsRequired();
    }
}
