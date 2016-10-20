using System;

namespace Cake.IIS.Settings
{
    public class ApplicationPoolSettings
    {
        private string _Username;

        public ApplicationPoolSettings()
        {
            this.Name = "ASP.NET v4.0";
            this.ManagedRuntimeVersion = "v4.0";

            this.IdentityType = IdentityType.ApplicationPoolIdentity;
            this.ClassicManagedPipelineMode = false;
            this.Enable32BitAppOnWin64 = false;

            this.Autostart = true;
            this.Overwrite = false;

            this.PingInterval = TimeSpan.MinValue;
            this.PingResponseTime = TimeSpan.MinValue;
            this.IdleTimeout = TimeSpan.MinValue;
            this.ShutdownTimeLimit = TimeSpan.MinValue;
            this.StartupTimeLimit = TimeSpan.MinValue;
        }

        public string Name { get; set; }

        public IdentityType IdentityType { get; set; }

        public string Username
        {
            get
            {
                return _Username;
            }
            set
            {
                _Username = value;

                if (!string.IsNullOrEmpty(value))
                {
                    this.IdentityType = IdentityType.SpecificUser;
                }
            }
        }

        public string Password { get; set; }

        public string ManagedRuntimeVersion { get; set; }

        public bool ClassicManagedPipelineMode { get; set; }

        public bool Enable32BitAppOnWin64 { get; set; }

        public bool LoadUserProfile { get; set; }

        public long MaxProcesses { get; set; }

        public bool PingingEnabled { get; set; }

        public TimeSpan PingInterval { get; set; }

        public TimeSpan PingResponseTime { get; set; }

        public TimeSpan IdleTimeout { get; set; }

        public TimeSpan ShutdownTimeLimit { get; set; }

        public TimeSpan StartupTimeLimit { get; set; }

        public bool Autostart { get; set; }

        public bool Overwrite { get; set; }
    }
}