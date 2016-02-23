using System.Collections.Generic;
using System.Data.Entity;
using System.Web.Http;
using ToDo.Core;
using ToDo.Models;

namespace ToDo.Controllers
{
	public class IconClassesController : ApiController
	{
		private IGenericRepository<IconClass> _repository = new IconClassRepository(new ApplicationDbContext());

		public IconClassesController()
		{

		}

		public IconClassesController(DbContext context)
		{
			_repository = new IconClassRepository(context);
		}

		public IconClassesController(IconClassRepository repository)
		{
			_repository = repository;
		}

		// GET: api/IconClasses
		public IEnumerable<IconClass> Get()
		{
			return _repository.GetAll();
		}
	}
}