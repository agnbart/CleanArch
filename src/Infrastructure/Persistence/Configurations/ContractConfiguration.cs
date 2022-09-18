using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Infrastructure.Persistence.Configurations;
public class ContractConfiguration : IEntityTypeConfiguration<Contract>
{
    public void Configure(EntityTypeBuilder<Contract> builder)
    {
        builder.Property(x => x.ContractId).HasMaxLength(9).IsRequired();
        builder.Property(x => x.Contractor1).HasMaxLength(10).IsRequired();
        builder.Property(x => x.Contractor1Description).HasMaxLength(256);
        builder.Property(x => x.Contractor2).HasMaxLength(10).IsRequired();
        builder.Property(x => x.Contractor2Description).HasMaxLength(256);
        builder.Property(x => x.ContractDate).IsRequired();
        builder.Property(x => x.ContractDescription).HasMaxLength(256);
    }
}
