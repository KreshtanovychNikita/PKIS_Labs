using Lab4.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lab4.Configurations;

internal sealed class GoodsConfiguration : IEntityTypeConfiguration<Goods>
{
    public void Configure(EntityTypeBuilder<Goods> builder)
    {
        builder.Property(r => r.GoodsName).IsRequired();
        builder.Property(r => r.Description).IsRequired();
        builder.Property(x => x.Price).IsRequired().HasColumnType("dolars").HasPrecision(6);
        builder.Property(r => r.Discount).IsRequired();
        builder.Property(r => r.CalculateV).IsRequired();
    }
}
