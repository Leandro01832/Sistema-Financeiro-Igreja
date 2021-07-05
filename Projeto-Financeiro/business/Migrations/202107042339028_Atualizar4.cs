namespace business.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Atualizar4 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Admin");
            CreateTable(
                "dbo.Pessoa",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Contato",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Telefone = c.String(),
                        Whatsapp = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pessoa", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Movimentacao",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Data = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MovimentacaoEntrada",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Pago = c.Boolean(nullable: false),
                        DataRecebimento = c.DateTime(nullable: false),
                        Pessoa_ = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Movimentacao", t => t.Id)
                .ForeignKey("dbo.Pessoa", t => t.Pessoa_)
                .Index(t => t.Id)
                .Index(t => t.Pessoa_);
            
            CreateTable(
                "dbo.Cantina",
                c => new
                    {
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MovimentacaoEntrada", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Dizimo",
                c => new
                    {
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MovimentacaoEntrada", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.MovimentacaoSaida",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Pago = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Movimentacao", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Aluguel",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        NomeProduto = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MovimentacaoSaida", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Compra",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        NomeProduto = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MovimentacaoSaida", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Retiro",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Local = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MovimentacaoSaida", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Transacao",
                c => new
                    {
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MovimentacaoSaida", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Transporte",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Gasolina = c.Boolean(nullable: false),
                        Alcool = c.Boolean(nullable: false),
                        Diesel = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MovimentacaoSaida", t => t.Id)
                .Index(t => t.Id);
            
            AlterColumn("dbo.Admin", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Admin", "Id");
            CreateIndex("dbo.Admin", "Id");
            AddForeignKey("dbo.Admin", "Id", "dbo.Pessoa", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transporte", "Id", "dbo.MovimentacaoSaida");
            DropForeignKey("dbo.Transacao", "Id", "dbo.MovimentacaoSaida");
            DropForeignKey("dbo.Retiro", "Id", "dbo.MovimentacaoSaida");
            DropForeignKey("dbo.Compra", "Id", "dbo.MovimentacaoSaida");
            DropForeignKey("dbo.Aluguel", "Id", "dbo.MovimentacaoSaida");
            DropForeignKey("dbo.MovimentacaoSaida", "Id", "dbo.Movimentacao");
            DropForeignKey("dbo.Dizimo", "Id", "dbo.MovimentacaoEntrada");
            DropForeignKey("dbo.Cantina", "Id", "dbo.MovimentacaoEntrada");
            DropForeignKey("dbo.MovimentacaoEntrada", "Pessoa_", "dbo.Pessoa");
            DropForeignKey("dbo.MovimentacaoEntrada", "Id", "dbo.Movimentacao");
            DropForeignKey("dbo.Admin", "Id", "dbo.Pessoa");
            DropForeignKey("dbo.Contato", "Id", "dbo.Pessoa");
            DropIndex("dbo.Transporte", new[] { "Id" });
            DropIndex("dbo.Transacao", new[] { "Id" });
            DropIndex("dbo.Retiro", new[] { "Id" });
            DropIndex("dbo.Compra", new[] { "Id" });
            DropIndex("dbo.Aluguel", new[] { "Id" });
            DropIndex("dbo.MovimentacaoSaida", new[] { "Id" });
            DropIndex("dbo.Dizimo", new[] { "Id" });
            DropIndex("dbo.Cantina", new[] { "Id" });
            DropIndex("dbo.MovimentacaoEntrada", new[] { "Pessoa_" });
            DropIndex("dbo.MovimentacaoEntrada", new[] { "Id" });
            DropIndex("dbo.Admin", new[] { "Id" });
            DropIndex("dbo.Contato", new[] { "Id" });
            DropPrimaryKey("dbo.Admin");
            AlterColumn("dbo.Admin", "Id", c => c.Int(nullable: false, identity: true));
            DropTable("dbo.Transporte");
            DropTable("dbo.Transacao");
            DropTable("dbo.Retiro");
            DropTable("dbo.Compra");
            DropTable("dbo.Aluguel");
            DropTable("dbo.MovimentacaoSaida");
            DropTable("dbo.Dizimo");
            DropTable("dbo.Cantina");
            DropTable("dbo.MovimentacaoEntrada");
            DropTable("dbo.Movimentacao");
            DropTable("dbo.Contato");
            DropTable("dbo.Pessoa");
            AddPrimaryKey("dbo.Admin", "Id");
        }
    }
}
