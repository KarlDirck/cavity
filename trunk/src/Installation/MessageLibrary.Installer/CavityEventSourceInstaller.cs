﻿namespace Cavity
{
    using System;
    using System.ComponentModel;
    using System.Configuration.Install;
    using System.Diagnostics;
    using System.IO;

    /// <summary>
    /// Installs the Cavity application event source.
    /// <para>This class cannot be inherited.</para>
    /// </summary>
    /// <remarks>
    /// <see href="http://support.microsoft.com/kb/329291">
    /// PRB: "Requested Registry Access Is Not Allowed" Error Message When ASP.NET Application Tries to Write New EventSource in the EventLog
    /// </see>
    /// </remarks>
    [RunInstaller(true)]
    public sealed class CavityEventSourceInstaller : Installer
    {
        public CavityEventSourceInstaller()
        {
            var lib = Path.Combine(ProgramFiles32, @"Cavity\Messages\Cavity.EventLog.lib");
            var installer = new EventLogInstaller
            {
                Source = "Task Management",
                Log = "Cavity",
                CategoryCount = 2,
                CategoryResourceFile = lib,
                MessageResourceFile = lib,
                ParameterResourceFile = lib
            };

            Installers.Add(installer);
        }

        private static string ProgramFiles32
        {
            get
            {
                var name = 8 == IntPtr.Size || !string.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432"))
                    ? "ProgramFiles(x86)"
                    : "ProgramFiles";

                return Environment.GetEnvironmentVariable(name);
            }
        }
    }
}