namespace TaxCalculatorGlobalBlue.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class madeIdAsString : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.TaxInputs");
            AlterColumn("dbo.TaxInputs", "Id", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.TaxInputs", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.TaxInputs");
            AlterColumn("dbo.TaxInputs", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.TaxInputs", "Id");
        }
    }
}
