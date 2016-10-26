namespace Cassantic.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _27102016 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountContact",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ContactID = c.Int(nullable: false),
                        AccountID = c.Int(nullable: false),
                        ContactRoleID = c.Int(nullable: false),
                        Name = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        LastModifiedDate = c.DateTime(nullable: false),
                        CreatedById = c.Int(nullable: false),
                        LastModifiedById = c.Int(nullable: false),
                        StatusID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Account", t => t.AccountID, cascadeDelete: true)
                .ForeignKey("dbo.Contact", t => t.ContactID, cascadeDelete: true)
                .Index(t => t.ContactID)
                .Index(t => t.AccountID);
            
            CreateTable(
                "dbo.Account",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.String(),
                        Name = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        LastModifiedDate = c.DateTime(nullable: false),
                        CreatedById = c.Int(nullable: false),
                        LastModifiedById = c.Int(nullable: false),
                        StatusID = c.Int(nullable: false),
                        Users_Id = c.Int(),
                        StateAndCity_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .ForeignKey("dbo.StateAndCities", t => t.StateAndCity_Id)
                .Index(t => t.Users_Id)
                .Index(t => t.StateAndCity_Id);
            
            CreateTable(
                "dbo.Activity",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AccountID = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        ActivityTypeID = c.Int(nullable: false),
                        ActivityRateID = c.Int(nullable: false),
                        ContactID = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        DurationMinutes = c.Int(nullable: false),
                        IsClosed = c.Boolean(nullable: false),
                        IsDalyActivity = c.Boolean(nullable: false),
                        Name = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        LastModifiedDate = c.DateTime(nullable: false),
                        CreatedById = c.Int(nullable: false),
                        LastModifiedById = c.Int(nullable: false),
                        StatusID = c.Int(nullable: false),
                        Users_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ActivityRate", t => t.ActivityRateID, cascadeDelete: true)
                .ForeignKey("dbo.ActivityType", t => t.ActivityTypeID, cascadeDelete: true)
                .ForeignKey("dbo.Contact", t => t.ContactID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .ForeignKey("dbo.Account", t => t.AccountID, cascadeDelete: true)
                .Index(t => t.AccountID)
                .Index(t => t.ActivityTypeID)
                .Index(t => t.ActivityRateID)
                .Index(t => t.ContactID)
                .Index(t => t.Users_Id);
            
            CreateTable(
                "dbo.ActivityRate",
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
            
            CreateTable(
                "dbo.ActivityType",
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
            
            CreateTable(
                "dbo.Contact",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Gender = c.Int(nullable: false),
                        BirthDay = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        LastModifiedDate = c.DateTime(nullable: false),
                        CreatedById = c.Int(nullable: false),
                        LastModifiedById = c.Int(nullable: false),
                        StatusID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ContactPhone",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PhoneTypeID = c.Int(nullable: false),
                        Number = c.String(),
                        Internal = c.String(),
                        Order = c.Int(nullable: false),
                        ContactID = c.Int(nullable: false),
                        Name = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        LastModifiedDate = c.DateTime(nullable: false),
                        CreatedById = c.Int(nullable: false),
                        LastModifiedById = c.Int(nullable: false),
                        StatusID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contact", t => t.ContactID, cascadeDelete: true)
                .Index(t => t.ContactID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Name = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        LastModifiedDate = c.DateTime(nullable: false),
                        CreatedById = c.Int(nullable: false),
                        LastModifiedById = c.Int(nullable: false),
                        StatusID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Notes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EntityID = c.Int(nullable: false),
                        EntityName = c.String(),
                        Content = c.String(),
                        UserID = c.Int(nullable: false),
                        Name = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        LastModifiedDate = c.DateTime(nullable: false),
                        CreatedById = c.Int(nullable: false),
                        LastModifiedById = c.Int(nullable: false),
                        StatusID = c.Int(nullable: false),
                        Users_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .Index(t => t.Users_Id);
            
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FriendlyName = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Company = c.String(),
                        City = c.String(),
                        Address1 = c.String(),
                        Address2 = c.String(),
                        ZipPostalCode = c.String(),
                        PhoneNumber = c.String(),
                        FaxNumber = c.String(),
                        CreatedOnUtc = c.DateTime(nullable: false),
                        Name = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        LastModifiedDate = c.DateTime(nullable: false),
                        CreatedById = c.Int(nullable: false),
                        LastModifiedById = c.Int(nullable: false),
                        StatusID = c.Int(nullable: false),
                        RegionID_Id = c.Int(),
                        Account_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StateAndCities", t => t.RegionID_Id)
                .ForeignKey("dbo.Account", t => t.Account_Id)
                .Index(t => t.RegionID_Id)
                .Index(t => t.Account_Id);
            
            CreateTable(
                "dbo.StateAndCities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Abbreviation = c.String(),
                        TwoLetterIsoCode = c.String(),
                        Name = c.String(),
                        RegionID = c.Int(nullable: false),
                        ParentID = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        UserID = c.Int(nullable: false),
                        Sort = c.Int(nullable: false),
                        SubjectToVat = c.Boolean(nullable: false),
                        AllowsBilling = c.Boolean(nullable: false),
                        AllowsShipping = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        LastModifiedDate = c.DateTime(nullable: false),
                        CreatedById = c.Int(nullable: false),
                        LastModifiedById = c.Int(nullable: false),
                        StatusID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StateAndCities", t => t.ParentID)
                .Index(t => t.ParentID);
            
            CreateTable(
                "dbo.AccountPhone",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PhoneTypeID = c.Int(nullable: false),
                        Number = c.String(),
                        Internal = c.String(),
                        Order = c.Int(nullable: false),
                        AccountID = c.Int(nullable: false),
                        Name = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        LastModifiedDate = c.DateTime(nullable: false),
                        CreatedById = c.Int(nullable: false),
                        LastModifiedById = c.Int(nullable: false),
                        StatusID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Account", t => t.AccountID, cascadeDelete: true)
                .Index(t => t.AccountID);
            
            DropTable("dbo.Advert");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Advert",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Thumb = c.String(),
                        Currency = c.String(),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.AccountContact", "ContactID", "dbo.Contact");
            DropForeignKey("dbo.AccountContact", "AccountID", "dbo.Account");
            DropForeignKey("dbo.AccountPhone", "AccountID", "dbo.Account");
            DropForeignKey("dbo.Addresses", "Account_Id", "dbo.Account");
            DropForeignKey("dbo.Addresses", "RegionID_Id", "dbo.StateAndCities");
            DropForeignKey("dbo.Account", "StateAndCity_Id", "dbo.StateAndCities");
            DropForeignKey("dbo.StateAndCities", "ParentID", "dbo.StateAndCities");
            DropForeignKey("dbo.Activity", "AccountID", "dbo.Account");
            DropForeignKey("dbo.Notes", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.Activity", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.Account", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.Activity", "ContactID", "dbo.Contact");
            DropForeignKey("dbo.ContactPhone", "ContactID", "dbo.Contact");
            DropForeignKey("dbo.Activity", "ActivityTypeID", "dbo.ActivityType");
            DropForeignKey("dbo.Activity", "ActivityRateID", "dbo.ActivityRate");
            DropIndex("dbo.AccountPhone", new[] { "AccountID" });
            DropIndex("dbo.StateAndCities", new[] { "ParentID" });
            DropIndex("dbo.Addresses", new[] { "Account_Id" });
            DropIndex("dbo.Addresses", new[] { "RegionID_Id" });
            DropIndex("dbo.Notes", new[] { "Users_Id" });
            DropIndex("dbo.ContactPhone", new[] { "ContactID" });
            DropIndex("dbo.Activity", new[] { "Users_Id" });
            DropIndex("dbo.Activity", new[] { "ContactID" });
            DropIndex("dbo.Activity", new[] { "ActivityRateID" });
            DropIndex("dbo.Activity", new[] { "ActivityTypeID" });
            DropIndex("dbo.Activity", new[] { "AccountID" });
            DropIndex("dbo.Account", new[] { "StateAndCity_Id" });
            DropIndex("dbo.Account", new[] { "Users_Id" });
            DropIndex("dbo.AccountContact", new[] { "AccountID" });
            DropIndex("dbo.AccountContact", new[] { "ContactID" });
            DropTable("dbo.AccountPhone");
            DropTable("dbo.StateAndCities");
            DropTable("dbo.Addresses");
            DropTable("dbo.Notes");
            DropTable("dbo.Users");
            DropTable("dbo.ContactPhone");
            DropTable("dbo.Contact");
            DropTable("dbo.ActivityType");
            DropTable("dbo.ActivityRate");
            DropTable("dbo.Activity");
            DropTable("dbo.Account");
            DropTable("dbo.AccountContact");
        }
    }
}
