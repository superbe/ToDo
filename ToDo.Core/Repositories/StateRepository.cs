using System;
using System.Data.Entity;
using System.Linq;

namespace ToDo.Core
{
	public class StateRepository : GenericRepository<State>
	{
		public StateRepository(DbContext context) : base(context)
		{

		}

		public override IQueryable<State> GetAll(string userId)
		{
			return _context.Set<State>().Where(x => x.Owner == userId);
		}
	}
}
