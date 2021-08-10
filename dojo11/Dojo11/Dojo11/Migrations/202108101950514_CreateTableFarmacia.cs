namespace Dojo11.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableFarmacia : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Farmacias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Cnpj = c.String(),
                        Localizacao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Farmacias");
        }
    }
}
