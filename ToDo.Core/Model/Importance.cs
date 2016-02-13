using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ToDo.Core
{
	/// <summary>
	/// Важность задачи. Справочник.
	/// </summary>
	public class Importance : Prototype
	{
		/// <summary>
		/// Название объекта списка задач.
		/// </summary>
		[DisplayName("Название важности задачи")]
		[StringLength(1024)]
		[Required(ErrorMessage = "Введите название важности задачи")]
		public string Name { get; set; }

		/// <summary>
		/// Задачи списка задач.
		/// </summary>
		public virtual IList<Task> Tasks { get; set; }
	}
}
