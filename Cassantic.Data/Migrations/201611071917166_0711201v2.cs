namespace Cassantic.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _0711201v2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Activity", "ActivityRateID", "dbo.ActivityRate");
            DropForeignKey("dbo.Activity", "ActivityTypeID", "dbo.ActivityType");
            DropForeignKey("dbo.Activity", "ContactID", "dbo.Contact");
            AddForeignKey("dbo.Activity", "ActivityRateID", "dbo.ActivityRate", "Id");
            AddForeignKey("dbo.Activity", "ActivityTypeID", "dbo.ActivityType", "Id");
            AddForeignKey("dbo.Activity", "ContactID", "dbo.Contact", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Activity", "ContactID", "dbo.Contact");
            DropForeignKey("dbo.Activity", "ActivityTypeID", "dbo.ActivityType");
            DropForeignKey("dbo.Activity", "ActivityRateID", "dbo.ActivityRate");
            AddForeignKey("dbo.Activity", "ContactID", "dbo.Contact", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Activity", "ActivityTypeID", "dbo.ActivityType", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Activity", "ActivityRateID", "dbo.ActivityRate", "Id", cascadeDelete: true);
        }
    }
}
