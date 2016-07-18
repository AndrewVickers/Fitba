namespace Fitba.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyGamesTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Games", "Venue", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Games", "Venue", c => c.String());
        }
    }
}
