using ConstructionAdmin.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConstructionAdmin.Data.Map
{
    public class StockMap : IEntityTypeConfiguration<Stock>
    {
        public void Configure(EntityTypeBuilder<Stock> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Date_Stock)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(c => c.Quantidade)
                .IsRequired()
                .HasColumnType("integer");

            builder.HasOne(c => c.Item)
                .WithOne(p => p.Stock)
                .HasForeignKey<Item>(p => p.StockId);

            builder.ToTable("Stock");
        }
    }
}
