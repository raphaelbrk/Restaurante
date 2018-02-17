using SistemaRestaurante.Negocio.Classes;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SistemaRestaurante.Persistencia.MapeamentoModelo
{
    public sealed class MapeamentoRestaurante : EntityTypeConfiguration<Restaurante>
    {
        public MapeamentoRestaurante()
        {
            ToTable("dbo.Restaurantes");

            HasKey(x => x.Codigo)
                   .Property(x => x.Codigo)
                   .HasColumnName("Codigo")
                   .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                   .IsRequired();

            Property(x => x.Nome)
                   .HasColumnName("Nome")
                   .IsRequired()
                   .HasMaxLength(100);
        }
    }
}