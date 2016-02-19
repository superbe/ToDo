using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ToDo.Core
{
	/// <summary>
	/// Задача.
	/// </summary>
	public class Task : Prototype
	{
		/// <summary>
		/// Состояние исполнения задачи.
		/// </summary>
		[DisplayName("Состояние исполнения")]
		public Guid StateID { get; set; }
		public virtual State State { get; set; }

		/// <summary>
		/// Цель.
		/// </summary>
		[DisplayName("Цель")]
		public Guid GoalId { get; set; }
		public virtual Goal Goal { get; set; }

		/// <summary>
		/// Важность.
		/// </summary>
		public int Importance { get; set; }

		/// <summary>
		/// Сроки оценки выполнения задачи.
		/// </summary>
		public double Estimate { get; set; }

		/// <summary>
		/// Описание желаемого рузультата.
		/// </summary>
		public string Result { get; set; }

		/// <summary>
		/// Подзадачи.
		/// </summary>
		public virtual IList<SubTask> SubTasks { get; set; }
	}
}
