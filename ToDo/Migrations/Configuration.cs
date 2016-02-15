namespace ToDo.Migrations
{
	using Core;
	using Models;
	using System.Data.Entity.Migrations;

	internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = true;
		}

		protected override void Seed(ApplicationDbContext context)
		{
			context.Importances.AddOrUpdate(
			p => p.Name,
			new Importance { Id = 1, Name = "Запланировано", ColorClass = "warning", IconImage = "glyphicon glyphicon-exclamation-sign" },
			new Importance { Id = 2, Name = "В работе", ColorClass = "active", IconImage = "glyphicon glyphicon-refresh" },
			new Importance { Id = 3, Name = "Выполнено", ColorClass = "success", IconImage = "glyphicon glyphicon-ok" }
			);
		}
	}
}
