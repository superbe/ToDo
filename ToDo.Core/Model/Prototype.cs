using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace ToDo.Core
{
	/// <summary>
	/// Прототип свойств основных объектов списка задач.
	/// </summary>
	public abstract class Prototype : ITask
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
		/// Идентификатор объекта списка задач.
		/// </summary>
		/// <remarks>Реализация интерфейса ITask.</remarks>
		[Key]
		[HiddenInput]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid Id { get; set; }

		/// <summary>
		/// Идентификатор собственника (UserId).
		/// </summary>
		/// <remarks>Реализация интерфейса ITask.</remarks>
		[Required]
		[HiddenInput]
		public string Owner { get; set; }

		/// <summary>
		/// Дата создания.
		/// </summary>
		/// <remarks>Реализация интерфейса ITask.</remarks>
		[Required]
		[HiddenInput]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public DateTime Created { get; set; }

		/// <summary>
		/// Дата последнего изменения.
		/// </summary>
		/// <remarks>Реализация интерфейса ITask.</remarks>
		[Required]
		[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
		[HiddenInput]
		public DateTime Changed { get; set; }
	}
}