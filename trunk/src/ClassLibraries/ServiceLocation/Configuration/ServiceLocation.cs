﻿namespace Cavity.Configuration
{
    using System.ComponentModel;
    using System.Configuration;
    using System.Diagnostics;
    using Cavity.Diagnostics;

    public sealed class ServiceLocation : ConfigurationSection
    {
        private static readonly TypeConverter _converter = new SetLocatorProviderConverter();

        private static readonly ConfigurationValidatorBase _validator = new SetLocatorProvideValidator();

        private static readonly ConfigurationProperty _provider = new ConfigurationProperty("type",
                                                                                            typeof(ISetLocatorProvider),
                                                                                            null,
                                                                                            _converter,
                                                                                            _validator,
                                                                                            ConfigurationPropertyOptions.IsRequired);

        public ServiceLocation()
        {
            Trace.WriteIf(Tracing.Enabled, string.Empty);
            Properties.Add(_provider);
        }

        public ISetLocatorProvider Provider
        {
            get
            {
                return (ISetLocatorProvider)this["type"];
            }

            set
            {
                this["type"] = value;
            }
        }
    }
}