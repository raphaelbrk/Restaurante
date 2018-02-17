namespace SistemaRestaurante.Persistencia
{
    using Negocio.Classes;
    using System.Data.Entity;

    public class RestauranteModel : DbContext
    {
        public RestauranteModel()
            : base("name=RestauranteModel")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
            Database.SetInitializer<RestauranteModel>(null);
        }

        public DbSet<Restaurante> Restaurantes { get; set; }
        public DbSet<Prato> Pratos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MapeamentoModelo.MapeamentoRestaurante());
            modelBuilder.Configurations.Add(new MapeamentoModelo.MapeamentoPrato());
            base.OnModelCreating(modelBuilder);
        }
    }
}