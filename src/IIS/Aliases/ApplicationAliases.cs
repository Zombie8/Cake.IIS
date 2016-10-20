﻿using Microsoft.Web.Administration;

using Cake.Core;
using Cake.Core.Annotations;
using Cake.IIS.Managers;
using Cake.IIS.Settings;

namespace Cake.IIS.Aliases
{
    /// <summary>
    /// Contains aliases for working with IIS virtual applications.
    /// </summary>
    [CakeAliasCategory("IIS")]
    [CakeNamespaceImport("Microsoft.Web.Administration")]
    public static class ApplicationAliases
    {
        /// <summary>
        /// Adds site application to local IIS.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="settings">The site binding settings.</param>
        [CakeMethodAlias]
        public static void AddSiteApplication(this ICakeContext context, ApplicationSettings settings)
        {
            context.AddSiteApplication("", settings);
        }

        /// <summary>
        /// Adds site application to remote IIS.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="server">The remote server name.</param>
        /// <param name="settings">The site binding settings.</param>
        [CakeMethodAlias]
        public static void AddSiteApplication(this ICakeContext context, string server, ApplicationSettings settings)
        {
            using (ServerManager manager = BaseManager.Connect(server))
            {
                settings.ComputerName = server;

                WebsiteManager
                    .Using(context.Environment, context.Log, manager)
                    .AddApplication(settings);
            }
        }

        /// <summary>
        /// Removes site application from local IIS.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="settings">The site binding settings.</param>
        [CakeMethodAlias]
        public static void RemoveSiteApplication(this ICakeContext context, ApplicationSettings settings)
        {
            context.RemoveSiteApplication("", settings);
        }

        /// <summary>
        /// Removes site application from remote IIS.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="server">The remote server name.</param>
        /// <param name="settings">The site binding settings.</param>
        [CakeMethodAlias]
        public static void RemoveSiteApplication(this ICakeContext context, string server, ApplicationSettings settings)
        {
            using (ServerManager manager = BaseManager.Connect(server))
            {
                WebsiteManager
                    .Using(context.Environment, context.Log, manager)
                    .RemoveApplication(settings);
            }
        }
    }
}
