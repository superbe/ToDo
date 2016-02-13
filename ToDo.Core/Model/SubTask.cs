using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Core
{
	public class SubTask : Task
	{

		/// <summary>
		/// Родительская задача.
		/// </summary>
		[DisplayName("Родительская задача")]
		public Guid TaskID { get; set; }
		public virtual Task Task { get; set; }
	}
}
