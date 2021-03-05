namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hanghoa : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Accounts");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        UseName = c.String(nullable: false, maxLength: 128),
                        PassWord = c.String(),
                    })
                .PrimaryKey(t => t.UseName);
            
        }
    }
}
