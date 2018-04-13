using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Crud.Models.Map
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("Categorias");

            builder.HasKey(k => k.ID)
                .HasName("ID");

            builder.Property(p => p.ID)
                .IsRequired()
                .UseSqlServerIdentityColumn();

            builder.Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(100)
                .HasMaxLength(3);

            builder.Property(p => p.Referencia)
                .HasMaxLength(100)
                .HasMaxLength(3);



        }
    }
}
