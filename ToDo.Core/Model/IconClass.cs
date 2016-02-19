using System.Collections.Generic;

namespace ToDo.Core
{
	/// <summary>
	/// Справочник изображения элемента справочника состояния задачи.
	/// </summary>
	public class IconClass : Directory
	{
		/// <summary>
		/// Элементы справочника состояния задачи, определенный для текущего элемента справочника изображения.
		/// </summary>
		public virtual IList<State> States { get; set; }
	}
}
