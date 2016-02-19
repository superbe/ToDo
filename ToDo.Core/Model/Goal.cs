using System.Collections.Generic;

namespace ToDo.Core
{
	/// <summary>
	/// Цель.
	/// </summary>
	public class Goal : Prototype
	{
		/// <summary>
		/// Задачи цели.
		/// </summary>
		public virtual ICollection<Task> Tasks { get; set; }

		/// <summary>
		/// Конструктор.
		/// </summary>
		public Goal()
		{
			Tasks = new HashSet<Task>();
		}
	}
}