using System.Collections.Generic;

namespace ToDo.Core
{
	/// <summary>
	/// Справочник изображения элемента справочника состояния задачи.
	/// </summary>
	public class IconClass : ReferenceBook
	{
		/// <summary>
		/// Элементы справочника состояния задачи, определенный для текущего элемента справочника изображения.
		/// </summary>
		public virtual ICollection<State> States { get; set; }

		/// <summary>
		/// Конструктор.
		/// </summary>
		public IconClass()
		{
			States = new HashSet<State>();
		}
	}
}