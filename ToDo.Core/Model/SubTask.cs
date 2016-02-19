using System;
using System.ComponentModel;

namespace ToDo.Core
{
	/// <summary>
	/// Подзадача.
	/// </summary>
	public class SubTask : Task
	{
		/// <summary>
		/// Родительская задача.
		/// </summary>
		[DisplayName("Состояние исполнения")]
		public Guid TaskID { get; set; }
		public virtual Task Task { get; set; }
	}
}
