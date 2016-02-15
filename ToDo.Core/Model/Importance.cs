using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace ToDo.Core
{
	/// <summary>
	/// Важность задачи. Справочник.
	/// </summary>
	public class Importance
	{
		/// <summary>
		/// Идентификатор важность задачи.
		/// </summary>
		[Key]
		[HiddenInput]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		/// <summary>
		/// Название объекта списка задач.
		/// </summary>
		[DisplayName("Название важности задачи")]
		[StringLength(1024)]
		[Required(ErrorMessage = "Введите название важности задачи")]
		public string Name { get; set; }

		/// <summary>
		/// Класс важности задачи.
		/// </summary>
		[DisplayName("Класс важности задачи")]
		[StringLength(7)]
		[Required(ErrorMessage = "Введите класс важности задачи")]
		public string ColorClass { get; set; }

		/// <summary>
		/// Класс иконки важности задачи.
		/// </summary>
		[DisplayName("Класс иконки важности задачи")]
		[StringLength(36)]
		[Required(ErrorMessage = "Введите класс иконки важности задачи")]
		public string IconImage { get; set; }
	}
}
