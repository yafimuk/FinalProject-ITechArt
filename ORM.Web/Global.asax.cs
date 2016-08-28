using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Http;
using ORM.Web.App_Start;
using StructureMap.Web.Pipeline;

namespace ORM.Web
{
	public class Global : HttpApplication
	{
		void Application_Start(object sender, EventArgs e)
		{
			// Code that runs on application startup
			AreaRegistration.RegisterAllAreas();
			GlobalConfiguration.Configure(WebApiConfig.Register);
			RouteConfig.RegisterRoutes(RouteTable.Routes);

			GlobalConfig.CustomizeConfig(GlobalConfiguration.Configuration);

			// Database Initializer could be defined there instead of web.config
			//System.Data.Entity.Database.SetInitializer(new ORMDatabaseInitializer());
		}

		protected void Application_EndRequest(object sender, EventArgs e)
		{
			// important for HttpContext lifecycles
			HttpContextLifecycle.DisposeAndClearAll();
		}
	}
}