namespace MVCFunLearn.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO membershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (1, 0, 0, 0)");
            Sql("INSERT INTO membershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (2, 30, 1, 10)");
            Sql("INSERT INTO membershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (3, 60, 3, 15)");
            Sql("INSERT INTO membershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (4, 200, 12, 20)");
        }
        
        public override void Down()
        {
        }
    }
}
