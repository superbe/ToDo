using System.Data.Entity;
using System.Linq;

namespace ToDo.Core
{
	/// <summary>
	/// Хранилище справочника классов цвета заливки.
	/// </summary>
	/// <see cref="http://getbootstrap.com/css/#tables-contextual-classes"/>
	public class ColorClassRepository : GenericRepository<ColorClass>
	{
		/// <summary>
		/// Конструктор.
		/// </summary>
		/// <param name="context"></param>
		public ColorClassRepository(DbContext context) : base(context)
		{

		}

		/// <summary>
		/// Получить все записи справочника классов цвета заливки.
		/// </summary>
		/// <param name="userId">Идентификатор пользователя.</param>
		/// <returns>Все записи справочника классов цвета заливки.</returns>
		public override IQueryable<ColorClass> GetAll(string userId)
		{
			return GetAll();
		}
	}
}
