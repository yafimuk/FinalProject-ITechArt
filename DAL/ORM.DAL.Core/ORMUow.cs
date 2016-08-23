using System;
using System.Data.Entity;
using System.Data.Entity.Validation;
using ORM.DAL.Interfaces;
using ORM.DAL.Interfaces.CustomRepositories;
using ORM.DAL.Models.Entities;
using StructureMap;

namespace ORM.DAL.Core
{
	public class ORMUow : IORMUow
	{
		private readonly DbContext _dbContext;
		private readonly IContainer _container;

		public ORMUow(IContainer container, DbContext dbContext)
		{
			_dbContext = dbContext;
			_container = container;
		}

		#region Repositories

		#region MsSQL

		public ICarDriversRepository CarDrivers
		{
			get
			{
				return GetRepository<ICarDriversRepository>();
			}
		}

		public IRepository<Car> Cars
		{
			get
			{
				return GetRepository<IRepository<Car>>();
			}
		}

		#endregion MsSQL

		#endregion

		/// <summary>
		/// Save pending changes to the database
		/// </summary>
		public void Commit()
		{
			try
			{
				_dbContext.SaveChanges();
			}
			catch (DbEntityValidationException e)
			{
				foreach (DbEntityValidationResult validationErrors in e.EntityValidationErrors)
				{
					foreach (DbValidationError validationError in validationErrors.ValidationErrors)
					{
						string errorMessage = string.Format("DB validation error. Property name: '{0}'. Error message: {1}",
							validationError.PropertyName, validationError.ErrorMessage);
					}
				}
				throw;
			}
			catch (Exception e)
			{
				//TODO: Log Error
				throw;
			}
		}

		public T GetRepository<T>() where T : class
		{
			DbContext dbContext1 = _container.GetInstance<DbContext>();
			DbContext dbContext2 = _container.GetInstance<DbContext>();
			if (Equals(dbContext1, dbContext2))
			{
				T repository = _container.GetInstance<T>();
				return repository;
			}
			return null;
		}

	}
}
