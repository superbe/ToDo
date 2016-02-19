using System;
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
	public class State : ReferenceBook, ITask
	{

		/// <summary>
		/// Идентификатор собственника (UserId).
		/// </summary>
		/// <remarks>Реализация интерфейса ITask.</remarks>
		[Required]
		[HiddenInput]
		public string Owner { get; set; }

		/// <summary>
		/// Дата создания элемента справочника.
		/// </summary>
		/// <remarks>Реализация интерфейса ITask.</remarks>
		[Required]
		[HiddenInput]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public DateTime Created { get; set; }

		/// <summary>
		/// Дата последнего изменения элемента справочника.
		/// </summary>
		/// <remarks>Реализация интерфейса ITask.</remarks>
		[Required]
		[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
		[HiddenInput]
		public DateTime Changed { get; set; }

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
		public virtual ICollection<Task> Tasks { get; set; }

		/// <summary>
		/// Конструктор.
		/// </summary>
		public State()
		{
			Tasks = new HashSet<Task>();
		}
	}
}