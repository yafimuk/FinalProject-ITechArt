using System.Data.Entity;
using ORM.DAL.Core;
using StructureMap.Configuration.DSL;
using StructureMap.Web;

namespace ORM.IoC.Registries
{
	/// <summary>
	/// Instructs <c>StructureMap</c> how to create services and all related objects.
	/// </summary>
	public class ApplicationContextRegistry : Registry
	{
		public ApplicationContextRegistry()
		{
			For<DbContext>().HybridHttpOrThreadLocalScoped().Use<ApplicationContext>();
		}
	}
}
