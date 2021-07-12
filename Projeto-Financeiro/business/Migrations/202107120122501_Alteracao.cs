namespace business.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Alteracao : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bazar",
                c => new
                    {
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MovimentacaoEntrada", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Lava_Rapido",
                c => new
                    {
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MovimentacaoEntrada", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Oferta",
                c => new
                    {
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MovimentacaoEntrada", t => t.Id)
                .Index(t => t.Id);
            
            DropColumn("dbo.MovimentacaoEntrada", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MovimentacaoEntrada", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            DropForeignKey("dbo.Oferta", "Id", "dbo.MovimentacaoEntrada");
            DropForeignKey("dbo.Lava_Rapido", "Id", "dbo.MovimentacaoEntrada");
            DropForeignKey("dbo.Bazar", "Id", "dbo.MovimentacaoEntrada");
            DropIndex("dbo.Oferta", new[] { "Id" });
            DropIndex("dbo.Lava_Rapido", new[] { "Id" });
            DropIndex("dbo.Bazar", new[] { "Id" });
            DropTable("dbo.Oferta");
            DropTable("dbo.Lava_Rapido");
            DropTable("dbo.Bazar");
        }
    }
}
