using System.Data.Entity.Migrations;

namespace Vidly.Migrations
{
    public partial class PopulateMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = 'Pay as you go' WHERE Id=1");
            Sql("UPDATE MembershipTypes SET Name = 'Montly' WHERE Id=3");
            Sql("UPDATE MembershipTypes SET Name = 'Quartely' WHERE Id=3");
            Sql("UPDATE MembershipTypes SET Name = 'Annual' WHERE Id=4");
        }

        public override void Down()
        {
        }
    }
}
