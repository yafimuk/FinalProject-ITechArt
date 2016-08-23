// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StructuremapMvc.cs" company="Web Advanced">
// Copyright 2012 Web Advanced (www.webadvanced.com)
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0

// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Web.Http;
using System.Web.Mvc;
using ORM.IoC;
using ORM.Web.App_Start;
using ORM.Web.Helpers.StructureMap;
using StructureMap;
using WebActivatorEx;

[assembly: PreApplicationStartMethod(typeof(StructuremapMvc), "Start")]

namespace ORM.Web.App_Start
{
	public static class StructuremapMvc
	{
		#region Public Methods and Operators

		private static IContainer _container;
		internal static IContainer Container
		{
			get { return _container ?? (_container = IocConfigurator.Initialize()); }
		}

		public static void Start()
		{
			DependencyResolver.SetResolver(new StructureMapDependencyResolver(Container));
			GlobalConfiguration.Configuration.DependencyResolver = new StructureMapDependencyResolver(Container);
		}

		#endregion
	}
}