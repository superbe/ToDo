using System;
using System.Linq;
using ToDo.Core;

namespace ToDo.Tests
{
	public class TestColorClassDbSet : TestDbSet<ColorClass>
	{
		public override ColorClass Find(params object[] keyValues)
		{
			return this.SingleOrDefault(color => color.Id == (Guid)keyValues.Single());
		}
	}

}
