﻿namespace Cavity
{
    using System.ServiceProcess;

    public static class Program
    {
        public static void Main()
        {
            ServiceBase.Run(new ServiceBase[]
            {
                new TaskManagementService()
            });
        }
    }
}