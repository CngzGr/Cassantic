namespace Cassantic.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _23102016 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Advert", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Advert", "Thumb", c => c.String());
            AddColumn("dbo.Advert", "Currency", c => c.String());
            AddColumn("dbo.Advert", "Content", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Advert", "Content");
            DropColumn("dbo.Advert", "Currency");
            DropColumn("dbo.Advert", "Thumb");
            DropColumn("dbo.Advert", "Price");
        }
    }
}
