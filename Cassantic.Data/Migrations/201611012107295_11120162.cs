namespace Cassantic.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _11120162 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContactRole",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        LastModifiedDate = c.DateTime(nullable: false),
                        CreatedById = c.Int(nullable: false),
                        LastModifiedById = c.Int(nullable: false),
                        StatusID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.AccountContact", "ContactRoleID");
            AddForeignKey("dbo.AccountContact", "ContactRoleID", "dbo.ContactRole", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AccountContact", "ContactRoleID", "dbo.ContactRole");
            DropIndex("dbo.AccountContact", new[] { "ContactRoleID" });
            DropTable("dbo.ContactRole");
        }
    }
}
