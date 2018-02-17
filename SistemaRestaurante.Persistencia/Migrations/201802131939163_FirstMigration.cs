namespace SistemaRestaurante.Persistencia.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pratos",
                c => new
                {
                    Restaurante = c.Int(nullable: false, identity: true),
                    Codigo = c.Int(nullable: false, identity: true),
                    Nome = c.String(nullable: false, maxLength: 100),
                    Valor = c.Double(nullable: false),
                })
                .PrimaryKey(t => t.Restaurante);

            CreateTable(
                "dbo.Restaurantes",
                c => new
                {
                    Codigo = c.Int(nullable: false, identity: true),
                    Nome = c.String(nullable: false, maxLength: 100),
                })
                .PrimaryKey(t => t.Codigo);
        }

        public override void Down()
        {
            DropTable("dbo.Restaurantes");
            DropTable("dbo.Pratos");
        }
    }
}