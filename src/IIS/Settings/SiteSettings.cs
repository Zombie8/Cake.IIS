using Cake.Core.IO;
using Cake.IIS.Bindings;

namespace Cake.IIS.Settings
{
    public abstract class SiteSettings : IDirectorySettings
    {
        public SiteSettings()
            : base()
        {
            this.Binding = IISBindings.Http;

            this.ServerAutoStart = true;
            this.Overwrite = false;

            this.ApplicationPool = new ApplicationPoolSettings();
        }

        public string Name { get; set; }

        public string ComputerName { get; set; }

        public DirectoryPath WorkingDirectory { get; set; }

        public DirectoryPath PhysicalDirectory { get; set; }

        public BindingSettings Binding { get; set; }

        public ApplicationPoolSettings ApplicationPool { get; set; }

        public AuthenticationSettings Authentication { get; set; }

        public AuthorizationSettings Authorization { get; set; }

        public bool TraceFailedRequestsEnabled { get; set; }

        public string TraceFailedRequestsDirectory { get; set; }

        public long TraceFailedRequestsMaxLogFiles { get; set; }

        public bool ServerAutoStart { get; set; }

        public bool Overwrite { get; set; }
    }
}