namespace Cassantic.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _07112016 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Notes", newName: "Note");
            RenameTable(name: "dbo.Addresses", newName: "Address");
            RenameTable(name: "dbo.StateAndCities", newName: "StateAndCity");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.StateAndCity", newName: "StateAndCities");
            RenameTable(name: "dbo.Address", newName: "Addresses");
            RenameTable(name: "dbo.Note", newName: "Notes");
        }
    }
}
