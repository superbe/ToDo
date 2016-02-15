using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ToDo.Core
{
	/// <summary>
	/// Задача.
	/// </summary>
	public class Task : Prototype
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
		/// Важность задачи.
		/// </summary>
		[DisplayName("Важность задачи")]
		public int ImportanceID { get; set; }
	}
}
