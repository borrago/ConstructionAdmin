using ConstructionAdmin.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConstructionAdmin.Data.Map
{
    public class RequisicaoMap : IEntityTypeConfiguration<Requisicao>
    {
        public void Configure(EntityTypeBuilder<Requisicao> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Data_Requesicao)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(c => c.Estado_Requesicao)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(c => c.Justificacao)
                .IsRequired()
                .HasColumnType("varchar(500)");

            builder.Property(c => c.Observacao)
                .IsRequired()
                .HasColumnType("varchar(500)");

            builder.HasOne(c => c.Item)
                .WithOne(p => p.Requisicao)
                .HasForeignKey<Item>(p => p.RequisicaoId);

            builder.ToTable("Requisicao");
        }
    }
}
