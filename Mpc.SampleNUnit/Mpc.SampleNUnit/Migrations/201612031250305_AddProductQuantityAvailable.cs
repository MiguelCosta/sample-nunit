namespace Mpc.SampleNUnit.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProductQuantityAvailable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "QuantityAvailable", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "QuantityAvailable");
        }
    }
}
