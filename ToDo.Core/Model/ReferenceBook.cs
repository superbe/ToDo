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
	public abstract class ReferenceBook : IReferenceBook
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