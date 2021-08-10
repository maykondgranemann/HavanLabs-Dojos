namespace Dojo11.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableDrogas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Drogas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Brisa = c.String(),
                        Peso = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Drogas");
        }
    }
}
