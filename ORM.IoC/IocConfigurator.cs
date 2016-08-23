using ORM.IoC.Registries;
using StructureMap;

namespace ORM.IoC
{
	/// <summary>
	/// Class to store configuration of <c>Ioc</c> container.
	/// </summary>
	public static class IocConfigurator
	{
		/// <summary>
		/// Configures the IoC container.
		/// </summary>
		private static void Configure(IContainer container)
		{
			container.Configure(config =>
			{
				config.AddRegistry<ORMDbContextRegistry>();
				config.AddRegistry<RepositoryRegistry>();
				config.AddRegistry<ControllerRegistry>();
				config.AddRegistry<BusinessLogicRegistry>();
			});
		}

		/// <summary>
		/// Return instance of IoC container
		/// </summary>
		public static IContainer Initialize()
		{
			IContainer container = ObjectFactory.Container;
			Configure(container);
			return container;
		}
	}
}
