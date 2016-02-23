using System.Data.Entity;
using ToDo.Core;

namespace ToDo.Tests
{
	/// <summary>
	/// Тестовый контекст базы данных.
	/// </summary>
	public class TestToDoAppContext : DbContext
	{
		/// <summary>
		/// Конструктор.
		/// </summary>
		public TestToDoAppContext()
		{
			ColorClasses = new TestDbSet<ColorClass>();
			Goals = new TestDbSet<Goal>();
			IconClasses = new TestDbSet<IconClass>();
			States = new TestDbSet<State>();
			SubTasks = new TestDbSet<SubTask>();
			Tasks = new TestDbSet<Task>();
		}

		public DbSet<ColorClass> ColorClasses { get; set; }
		public DbSet<Goal> Goals { get; set; }
		public DbSet<IconClass> IconClasses { get; set; }
		public DbSet<State> States { get; set; }
		public DbSet<SubTask> SubTasks { get; set; }
		public DbSet<Task> Tasks { get; set; }
	}
}