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
		public virtual IList<Task> Tasks { get; set; }
	}
}
