namespace Behaviors.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Seed : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BehaviorEntries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ChildId = c.Int(nullable: false),
                        BehaviorId = c.Int(nullable: false),
                        DateAndTime = c.DateTime(nullable: false),
                        DurationMinutes = c.Int(nullable: false),
                        DurationSeconds = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Behaviors", t => t.BehaviorId, cascadeDelete: true)
                .ForeignKey("dbo.Children", t => t.ChildId, cascadeDelete: true)
                .Index(t => t.ChildId)
                .Index(t => t.BehaviorId);
            
            CreateTable(
                "dbo.Behaviors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Children",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BehaviorEntries", "ChildId", "dbo.Children");
            DropForeignKey("dbo.BehaviorEntries", "BehaviorId", "dbo.Behaviors");
            DropIndex("dbo.BehaviorEntries", new[] { "BehaviorId" });
            DropIndex("dbo.BehaviorEntries", new[] { "ChildId" });
            DropTable("dbo.Children");
            DropTable("dbo.Behaviors");
            DropTable("dbo.BehaviorEntries");
        }
    }
}
