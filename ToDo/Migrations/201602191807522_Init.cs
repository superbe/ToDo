namespace ToDo.Migrations
{
	using System;
	using System.Data.Entity.Migrations;

	public partial class Init : DbMigration
	{
		public override void Up()
		{
			CreateTable(
				"dbo.ColorClasses",
				c => new
				{
					Id = c.Guid(nullable: false, identity: true),
					Name = c.String(nullable: false, maxLength: 1024),
					Value = c.String(nullable: false, maxLength: 1024),
				})
				.PrimaryKey(t => t.Id);

			CreateTable(
				"dbo.States",
				c => new
				{
					Id = c.Guid(nullable: false, identity: true),
					Owner = c.String(nullable: false),
					Created = c.DateTime(nullable: false),
					Changed = c.DateTime(nullable: false),
					ColorClassId = c.Guid(nullable: false),
					IconClassId = c.Guid(nullable: false),
					Name = c.String(nullable: false, maxLength: 1024),
					Value = c.String(nullable: false, maxLength: 1024),
				})
				.PrimaryKey(t => t.Id)
				.ForeignKey("dbo.ColorClasses", t => t.ColorClassId, cascadeDelete: true)
				.ForeignKey("dbo.IconClasses", t => t.IconClassId, cascadeDelete: true)
				.Index(t => t.ColorClassId)
				.Index(t => t.IconClassId);

			CreateTable(
				"dbo.IconClasses",
				c => new
				{
					Id = c.Guid(nullable: false, identity: true),
					Name = c.String(nullable: false, maxLength: 1024),
					Value = c.String(nullable: false, maxLength: 1024),
				})
				.PrimaryKey(t => t.Id);

			CreateTable(
				"dbo.Tasks",
				c => new
				{
					Id = c.Guid(nullable: false, identity: true),
					StateID = c.Guid(nullable: false),
					GoalId = c.Guid(nullable: false),
					Importance = c.Int(nullable: false),
					Estimate = c.Double(nullable: false),
					Result = c.String(),
					Title = c.String(nullable: false, maxLength: 1024),
					Description = c.String(),
					Owner = c.String(nullable: false),
					Created = c.DateTime(nullable: false),
					Changed = c.DateTime(nullable: false),
					TaskID = c.Guid(),
					Discriminator = c.String(nullable: false, maxLength: 128),
				})
				.PrimaryKey(t => t.Id)
				.ForeignKey("dbo.Goals", t => t.GoalId, cascadeDelete: true)
				.ForeignKey("dbo.States", t => t.StateID, cascadeDelete: true)
				.ForeignKey("dbo.Tasks", t => t.TaskID)
				.Index(t => t.StateID)
				.Index(t => t.GoalId)
				.Index(t => t.TaskID);

			CreateTable(
				"dbo.Goals",
				c => new
				{
					Id = c.Guid(nullable: false, identity: true),
					Title = c.String(nullable: false, maxLength: 1024),
					Description = c.String(),
					Owner = c.String(nullable: false),
					Created = c.DateTime(nullable: false),
					Changed = c.DateTime(nullable: false),
				})
				.PrimaryKey(t => t.Id);

		}

		public override void Down()
		{
			DropForeignKey("dbo.Tasks", "TaskID", "dbo.Tasks");
			DropForeignKey("dbo.Tasks", "StateID", "dbo.States");
			DropForeignKey("dbo.Tasks", "GoalId", "dbo.Goals");
			DropForeignKey("dbo.States", "IconClassId", "dbo.IconClasses");
			DropForeignKey("dbo.States", "ColorClassId", "dbo.ColorClasses");
			DropIndex("dbo.Tasks", new[] { "TaskID" });
			DropIndex("dbo.Tasks", new[] { "GoalId" });
			DropIndex("dbo.Tasks", new[] { "StateID" });
			DropIndex("dbo.States", new[] { "IconClassId" });
			DropIndex("dbo.States", new[] { "ColorClassId" });
			DropTable("dbo.Goals");
			DropTable("dbo.Tasks");
			DropTable("dbo.IconClasses");
			DropTable("dbo.States");
			DropTable("dbo.ColorClasses");
		}
	}
}
