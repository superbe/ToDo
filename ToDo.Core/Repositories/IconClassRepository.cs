using System.Data.Entity;
using System.Linq;

namespace ToDo.Core
{
	/// <summary>
	/// Хранилище справочника изображения состояния задачи.
	/// </summary>
	/// <see cref="http://getbootstrap.com/components/#glyphicons"/>
	public class IconClassRepository : GenericRepository<IconClass>
	{
		/// <summary>
		/// Конструктор.
		/// </summary>
		/// <param name="context"></param>
		public IconClassRepository(DbContext context) : base(context)
		{

		}

		/// <summary>
		/// Получить все записи справочника изображения состояния задачи.
		/// </summary>
		/// <param name="userId">Идентификатор пользователя.</param>
		/// <returns>Все записи справочника изображения состояния задачи.</returns>
		public override IQueryable<IconClass> GetAll(string userId)
		{
			return GetAll();
		}
	}
}
