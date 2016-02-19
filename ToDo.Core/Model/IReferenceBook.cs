using System;

namespace ToDo.Core
{
	/// <summary>
	/// Интерфейс элемента справочника.
	/// </summary>
	public interface IReferenceBook
	{
		/// <summary>
		/// Идентификатор.
		/// </summary>
		Guid Id { get; set; }

		/// <summary>
		/// Название элемента справочника.
		/// </summary>
		string Name { get; set; }

		/// <summary>
		/// Значение элемента справочника.
		/// </summary>
		string Value { get; set; }
	}
}