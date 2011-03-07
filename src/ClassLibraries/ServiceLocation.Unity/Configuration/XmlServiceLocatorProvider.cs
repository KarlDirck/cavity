﻿namespace Cavity.Configuration
{
    using System.Configuration;
    using System.Diagnostics.CodeAnalysis;
    using Microsoft.Practices.ServiceLocation;
    using Microsoft.Practices.Unity;
    using Microsoft.Practices.Unity.Configuration;

    public sealed class XmlServiceLocatorProvider : ISetLocatorProvider
    {
        [SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Justification = "Disposing the container tears down the configuration.")]
        public void Configure()
        {
            IUnityContainer container = new UnityContainer();
            ((UnityConfigurationSection)ConfigurationManager.GetSection("unity")).Configure(container, "container");

            var locator = new UnityServiceLocator(container);
            ServiceLocator.SetLocatorProvider(() => locator);
        }
    }
}