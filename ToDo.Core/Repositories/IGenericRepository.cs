using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Core
{
	/// <summary>
	/// Интерфейс хранилища объектов.
	/// </summary>
	/// <typeparam name="T">Класс хранения.</typeparam>
	public interface IGenericRepository<T> where T : class
	{
		/// <summary>
		/// Получить все сущности. Первая перегрузка.
		/// </summary>
		/// <returns>Все хранимые сущности.</returns>
		IQueryable<T> GetAll();

		/// <summary>
		/// Получить все сущности. Вторая перегрузка.
		/// </summary>
		/// <param name="userId">Идентификатор пользователя.</param>
		/// <returns>Все хранимые сущности.</returns>
		IQueryable<T> GetAll(string userId);

		/// <summary>
		/// Найти конкретную сущность.
		/// </summary>
		/// <param name="predicate">Выражение поиска.</param>
		/// <returns>Результат поиска.</returns>
		IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);

		/// <summary>
		/// Добавить новую сущность.
		/// </summary>
		/// <param name="entity">Добавляемая сущность.</param>
		void Add(T entity);

		/// <summary>
		/// Удалить текущую сущность.
		/// </summary>
		/// <param name="entity">Удаляемая сущность.</param>
		void Delete(T entity);

		/// <summary>
		/// Править текущую сущность.
		/// </summary>
		/// <param name="entity">Текущая сущность.</param>
		void Edit(T entity);

		/// <summary>
		/// Сохранить изменения.
		/// </summary>
		void Save();
	}
}