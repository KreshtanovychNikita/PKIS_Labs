﻿using Lab4.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lab4.Configurations;

internal sealed class CompanyConfiguration : IEntityTypeConfiguration<Company>
{
    public void Configure(EntityTypeBuilder<Company> builder)
    {
        builder.Property(r => r.CompanyName).IsRequired();
        builder.Property(r => r.AddresCompany).IsRequired();
        builder.Property(r => r.PhoneCompanyNumber).IsRequired();
    }
}
