using SistemaRestaurante.Negocio.Classes;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SistemaRestaurante.Persistencia.MapeamentoModelo
{
    public sealed class MapeamentoPrato : EntityTypeConfiguration<Prato>
    {
        public MapeamentoPrato()
        {
            ToTable("dbo.Pratos");

            HasKey(x => x.Codigo)
                   .Property(x => x.Codigo)
                   .HasColumnName("Codigo")
                   .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                   .IsRequired();

            Property(x => x.CodigoRestaurante)
                   .HasColumnName("CodigoRestaurante")
                   .IsRequired();

            Property(x => x.Nome)
                   .HasColumnName("Nome")
                   .IsRequired()
                   .HasMaxLength(100);

            Property(x => x.Valor)
                   .HasColumnName("Valor")
                   .IsRequired();
        }
    }
}