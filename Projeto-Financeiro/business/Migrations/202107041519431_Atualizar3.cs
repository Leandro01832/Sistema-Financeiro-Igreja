namespace business.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Atualizar3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Admin", "Permissao", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Admin", "Permissao");
        }
    }
}
