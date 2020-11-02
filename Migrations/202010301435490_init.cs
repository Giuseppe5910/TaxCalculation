namespace TaxCalculatorGlobalBlue.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TaxInputs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VAT = c.Int(nullable: false),
                        Net = c.Single(nullable: false),
                        Gross = c.Single(nullable: false),
                        Total = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TaxInputs");
        }
    }
}
