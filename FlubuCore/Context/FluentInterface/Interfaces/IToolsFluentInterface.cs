﻿using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Tasks.NetCore;

namespace FlubuCore.Context.FluentInterface.Interfaces
{
    public interface IToolsFluentInterface
    {
        /// <summary>
        /// Installs a tool for use on the command line.
        /// </summary>
        /// <param name="nugetPackageId">NuGet Package Id of the tool to install.</param>
        DotnetToolInstall Install(string nugetPackageId);

        /// <summary>
        /// Updates a tool to the latest stable version for use.
        /// </summary>
        /// <param name="nugetPackageiD"></param>
        /// <returns></returns>
        DotnetToolUpdate Update(string nugetPackageiD);
    }
}
