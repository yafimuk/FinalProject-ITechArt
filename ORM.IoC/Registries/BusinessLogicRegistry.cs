using ORM.BusinessLogic.Common;
using ORM.BusinessLogic.Core;
using StructureMap.Configuration.DSL;

namespace ORM.IoC.Registries
{
	/// <summary>
	/// Instructs <c>StructureMap</c> how to create services and all related objects.
	/// </summary>
	public class BusinessLogicRegistry : Registry
	{
		public BusinessLogicRegistry()
		{
			Scan(x =>
			{
				x.AssemblyContainingType<ICarService>();
				x.AssemblyContainingType<CarService>();
				x.WithDefaultConventions();
			});
		}
	}
}
