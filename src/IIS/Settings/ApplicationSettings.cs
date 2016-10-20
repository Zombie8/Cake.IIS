using System;
using Cake.Core.IO;

namespace Cake.IIS.Settings
{
    public class ApplicationSettings : IDirectorySettings
    {
        public string ComputerName { get; set; }

        public string SiteName { get; set; }

        public string ApplicationPath { get; set; }

        public string ApplicationPool { get; set; }

        public string VirtualDirectory { get; set; }

        public DirectoryPath WorkingDirectory { get; set; }

        public DirectoryPath PhysicalDirectory { get; set; }

        public AuthenticationSettings Authentication { get; set; }

        public AuthorizationSettings Authorization { get; set; }

        [Obsolete("Use Authentication.UserName")]
        public string UserName
        {
            get
            {
                return this.Authentication.Username;
            }
            set
            {
                if (this.Authentication == null)
                {
                    this.Authentication = new AuthenticationSettings();
                }

                this.Authentication.Username = value;
            }
        }

        [Obsolete("Use Authentication.Password")]
        public string Password
        {
            get
            {
                return this.Authentication.Password;
            }
            set
            {
                if (this.Authentication == null)
                {
                    this.Authentication = new AuthenticationSettings();
                }

                this.Authentication.Password = value;
            }
        }
    }
}