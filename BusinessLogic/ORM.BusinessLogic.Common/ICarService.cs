using System.Linq;
using ORM.DAL.Models.Entities;

namespace ORM.BusinessLogic.Common
{
	public interface ICarService
	{
		IQueryable<Car> GetAll();

		void CreateRandomCar();
	}
}
