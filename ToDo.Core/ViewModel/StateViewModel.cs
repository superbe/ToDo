using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Core.ViewModel
{
	class StateViewModel
	{
		/// <summary>
		/// Идентификатор элемента справочника.
		/// </summary>
		public Guid Id { get; set; }

		/// <summary>
		/// Название элемента справочника.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Значение элемента справочника.
		/// </summary>
		public string Value { get; set; }

		/// <summary>
		/// Цвет важности задачи.
		/// </summary>
		public string Color { get; set; }

		/// <summary>
		/// Иконка важности задачи.
		/// </summary>
		public string Icon { get; set; }
	}
}
