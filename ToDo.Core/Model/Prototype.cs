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
	/// Прототип свойств основных объектов списка задач.
	/// </summary>
	public abstract class Prototype : ITask
	{
		/// <summary>
		/// Идентификатор объекта списка задач.
		/// </summary>
		/// <remarks>Реализация интерфейса ITask.</remarks>
		[Key]
		[HiddenInput]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

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
