namespace FilmSite.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updt : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Films", "Image", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Films", "Image", c => c.Binary(nullable: false));
        }
    }
}
