using System.Collections.Generic;
using System.Data.Entity;
using System.Web.Http;
using ToDo.Core;
using ToDo.Models;

namespace ToDo.Controllers
{
	public class ColorClassesController : ApiController
	{
		private IGenericRepository<ColorClass> _repository = new ColorClassRepository(new ApplicationDbContext());

		public ColorClassesController()
		{

		}

		public ColorClassesController(DbContext context)
		{
			_repository = new ColorClassRepository(context);
		}

		public ColorClassesController(ColorClassRepository repository)
		{
			_repository = repository;
		}

		// GET: api/ColorClasses
		public IEnumerable<ColorClass> Get()
		{
			return _repository.GetAll();
		}
	}
}