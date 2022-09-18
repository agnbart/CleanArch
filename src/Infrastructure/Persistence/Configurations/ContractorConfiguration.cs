using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Infrastructure.Persistence.Configurations;
public class ContractorConfiguration : IEntityTypeConfiguration<Contractor>
{
    public void Configure(EntityTypeBuilder<Contractor> builder)
    {
        builder.Property(x => x.ContractorId).IsRequired();
        builder.Property(x => x.Name1).HasMaxLength(256);
        builder.Property(x => x.Name2).HasMaxLength(256);
        builder.Property(x => x.City).HasMaxLength(256);
        builder.Property(x => x.Nip).HasMaxLength(11).IsRequired();
    }
}
