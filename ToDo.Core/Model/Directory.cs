using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace ToDo.Core
{
	/// <summary>
	/// Прототип элемента справочника.
	/// </summary>
	public abstract class Directory : ITask
	{
		/// <summary>
		/// Идентификатор элемента справочника.
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
		/// Название элемента справочника.
		/// </summary>
		[DisplayName("Название элемента справочника")]
		[StringLength(1024)]
		[Required(ErrorMessage = "Введите название элемента справочника")]
		public string Name { get; set; }

		/// <summary>
		/// Значение элемента справочника.
		/// </summary>
		[DisplayName("Значение элемента справочника")]
		[StringLength(1024)]
		[Required(ErrorMessage = "Введите значение элемента справочника")]
		public string Value { get; set; }
	}
}
