namespace TaxCalculatorGlobalBlue.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class madePropsTaxClculatorModelAsDouble : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TaxInputs", "VAT", c => c.Double(nullable: false));
            AlterColumn("dbo.TaxInputs", "Net", c => c.Double(nullable: false));
            AlterColumn("dbo.TaxInputs", "Gross", c => c.Double(nullable: false));
            AlterColumn("dbo.TaxInputs", "Total", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TaxInputs", "Total", c => c.Single(nullable: false));
            AlterColumn("dbo.TaxInputs", "Gross", c => c.Single(nullable: false));
            AlterColumn("dbo.TaxInputs", "Net", c => c.Single(nullable: false));
            AlterColumn("dbo.TaxInputs", "VAT", c => c.Int(nullable: false));
        }
    }
}
