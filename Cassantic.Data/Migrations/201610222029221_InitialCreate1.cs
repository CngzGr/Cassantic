namespace Cassantic.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Advert", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Advert", "Name");
        }
    }
}
