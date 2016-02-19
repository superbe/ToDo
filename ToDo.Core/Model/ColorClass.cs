using System.Collections.Generic;

namespace ToDo.Core
{
	/// <summary>
	/// Справочник цвета элемента справочника состояния задачи.
	/// </summary>
	public class ColorClass : ReferenceBook
	{
		/// <summary>
		/// Элементы справочника состояния задачи, определенный для текущего элемента справочника цвета.
		/// </summary>
		public virtual ICollection<State> States { get; set; }

		/// <summary>
		/// Конструктор.
		/// </summary>
		public ColorClass()
		{
			States = new HashSet<State>();
		}
	}
}