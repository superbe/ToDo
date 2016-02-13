using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ToDo.Core
{
	/// <summary>
	/// Список задач.
	/// </summary>
	public class TaskList : Prototype
	{
		/// <summary>
		/// Название объекта списка задач.
		/// </summary>
		[DisplayName("Название")]
		[StringLength(1024)]
		[Required(ErrorMessage = "Введите название")]
		public string Title { get; set; }

		/// <summary>
		/// Описание объекта списка задач.
		/// </summary>
		[DisplayName("Описание")]
		[StringLength(4096)]
		public string Description { get; set; }

		/// <summary>
		/// Задачи текущего списка задач.
		/// </summary>
		public virtual IList<Task> Tasks { get; set; }
	}
}
