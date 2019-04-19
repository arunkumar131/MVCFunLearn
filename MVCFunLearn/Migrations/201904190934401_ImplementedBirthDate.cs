namespace MVCFunLearn.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImplementedBirthDate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MembershipTypes", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MembershipTypes", "Name", c => c.String());
        }
    }
}
