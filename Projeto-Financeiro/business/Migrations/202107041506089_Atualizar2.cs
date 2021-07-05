namespace business.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Atualizar2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Admin", "User", c => c.String(maxLength: 8000, unicode: false));
            CreateIndex("dbo.Admin", "User", unique: true, name: "USER");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Admin", "USER");
            AlterColumn("dbo.Admin", "User", c => c.String());
        }
    }
}
