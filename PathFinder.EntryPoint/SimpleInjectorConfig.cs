﻿using PathFinder.Security.DAL.Package;
using PathFinder.Security.WebApi.Package;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;

namespace PathFinder.EntryPoint
{
    public static class SimpleInjectorConfiguration
    {
        public static Container ConfigurationSimpleInjector()
        {
            Container container = new Container();
            container.Options.DefaultScopedLifestyle = new WebApiRequestLifestyle();

            return RegisterPackages(container);
        }

        private static Container RegisterPackages(Container container)
        {
            container.RegisterPackages(new[]
            {
                typeof(SecurityDalPackage).Assembly,
                typeof(SecurityWebApiPackage).Assembly
            });
            container.Verify();

            return container;
        }
    }
}
