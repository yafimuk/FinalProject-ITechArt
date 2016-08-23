using ORM.DAL.Core;
using ORM.DAL.Interfaces;
using ORM.DAL.Interfaces.CustomRepositories;
using ORM.DAL.Repositories;
using StructureMap.Configuration.DSL;
using StructureMap.Web;

namespace ORM.IoC.Registries
{
	/// <summary>
	/// Instructs <c>StructureMap</c> how to create services and all related objects.
	/// </summary>
	public class RepositoryRegistry : Registry
	{
		public RepositoryRegistry()
		{
			Scan(x =>
			{
				x.AssemblyContainingType<ICarDriversRepository>();
				x.AssemblyContainingType<CarDriversRepository>();
				x.WithDefaultConventions().OnAddedPluginTypes(t => t.HybridHttpOrThreadLocalScoped());
				x.AddAllTypesOf(typeof(IRepository<>));
			});

			For<IORMUow>().HybridHttpOrThreadLocalScoped().Use<ORMUow>();
		}
	}
}
