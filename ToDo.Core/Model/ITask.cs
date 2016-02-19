using System;

namespace ToDo.Core
{
	/// <summary>
	/// Интерфейс основных объектов списка задач.
	/// </summary>
	public interface ITask
	{
		/// <summary>
		/// Идентификатор.
		/// </summary>
		Guid Id { get; set; }

		/// <summary>
		/// Идентификатор собственника (UserId).
		/// </summary>
		string Owner { get; set; }

		/// <summary>
		/// Дата создания.
		/// </summary>
		DateTime Created { get; set; }

		/// <summary>
		/// Дата последнего изменения.
		/// </summary>
		DateTime Changed { get; set; }
	}
}