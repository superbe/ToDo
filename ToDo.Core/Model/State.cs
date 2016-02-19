using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ToDo.Core
{
	/// <summary>
	/// Важность задачи. Справочник.
	/// </summary>
	public class State : Directory
	{
		/// <summary>
		/// Цвет важности задачи.
		/// </summary>
		[DisplayName("Цвет важности задачи")]
		public Guid ColorClassId { get; set; }
		public ColorClass ColorClass { get; set; }

		/// <summary>
		/// Иконка важности задачи.
		/// </summary>
		[DisplayName("Иконка важности задачи")]
		public Guid IconClassId { get; set; }
		public IconClass IconClass { get; set; }
		
		/// <summary>
		/// Задачи на текущее состояние.
		/// </summary>
		public virtual IList<Task> Tasks { get; set; }
	}
}
