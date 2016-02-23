using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace ToDo.Core
{
	/// <summary>
	/// Шаблон (прототип) хранилища объектов.
	/// </summary>
	/// <typeparam name="T">Класс хранения.</typeparam>
	public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
	{

		protected DbContext _context;

		/// <summary>
		/// Конструктор.
		/// </summary>
		/// <param name="context"></param>
		public GenericRepository(DbContext context)
		{
			_context = context;
		}

		/// <summary>
		/// Получить все сущности. Первая перегрузка.
		/// </summary>
		/// <returns>Все хранимые сущности.</returns>
		public virtual IQueryable<T> GetAll()
		{
			return _context.Set<T>();
		}

		/// <summary>
		/// Получить все сущности. Вторая перегрузка.
		/// </summary>
		/// <param name="userId">Идентификатор пользователя.</param>
		/// <returns>Все хранимые сущности.</returns>
		public abstract IQueryable<T> GetAll(string userId);

		/// <summary>
		/// Найти конкретную сущность.
		/// </summary>
		/// <param name="predicate">Выражение поиска.</param>
		/// <returns>Результат поиска.</returns>
		public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
		{
			IQueryable<T> query = _context.Set<T>().Where(predicate);
			return query;
		}

		/// <summary>
		/// Добавить новую сущность.
		/// </summary>
		/// <param name="entity">Добавляемая сущность.</param>
		public virtual void Add(T entity)
		{
			_context.Set<T>().Add(entity);
		}

		/// <summary>
		/// Удалить текущую сущность.
		/// </summary>
		/// <param name="entity">Удаляемая сущность.</param>
		public virtual void Delete(T entity)
		{
			_context.Set<T>().Remove(entity);
		}

		/// <summary>
		/// Править текущую сущность.
		/// </summary>
		/// <param name="entity">Текущая сущность.</param>
		public virtual void Edit(T entity)
		{
			_context.Entry(entity).State = EntityState.Modified;
		}

		/// <summary>
		/// Сохранить изменения.
		/// </summary>
		public virtual void Save()
		{
			_context.SaveChanges();
		}
	}
}