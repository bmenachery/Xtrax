using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Core.Entities;

namespace Infrastructure.Data.Config
{
    public class FirmProductConfiguration: IEntityTypeConfiguration<FirmProduct>
    {
        public void Configure(EntityTypeBuilder<FirmProduct> builder)
        {
            builder.Property(f => f.Id).IsRequired();
            builder.Property(f => f.Name).IsRequired().HasMaxLength(100);
            builder.HasOne(f => f.Product).WithMany()
               .HasForeignKey(f => f.ProductId);

        }
    }
}