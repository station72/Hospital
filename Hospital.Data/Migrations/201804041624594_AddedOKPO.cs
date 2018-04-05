namespace Hospital.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TherapeuticInstitutions", "OKPO", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TherapeuticInstitutions", "OKPO");
        }
    }
}
