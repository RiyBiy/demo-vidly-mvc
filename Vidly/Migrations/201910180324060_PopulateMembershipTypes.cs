namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            //Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (1, 0, 0, 0)");
            //Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (2, 30, 1, 10)");
            //Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (3, 90, 3, 15)");
            //Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (4, 300, 12, 20)");

            Sql(
               "UPDATE MembershipTypes set Name = (CASE WHEN Id = 1 THEN 'Pay as You Go' WHEN Id = 2 THEN 'Monthly' WHEN Id = 3 THEN 'Quarterly' WHEN Id = 4 THEN 'Annual' END); ");
        }
        
        public override void Down()
        {
        }
    }
}
