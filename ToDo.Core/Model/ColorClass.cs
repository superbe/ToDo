using System.Collections.Generic;

namespace ToDo.Core
{
	/// <summary>
	/// Справочник цвета элемента справочника состояния задачи.
	/// </summary>
	public class ColorClass : Directory
	{
		/// <summary>
		/// Элементы справочника состояния задачи, определенный для текущего элемента справочника цвета.
		/// </summary>
		public virtual IList<State> States { get; set; }
	}
}
