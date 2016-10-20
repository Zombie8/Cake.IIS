using Cake.IIS.Bindings;

namespace Cake.IIS.Settings
{
    public class FtpsiteSettings : SiteSettings
    {
        public FtpsiteSettings()
            : base()
        {
            this.Binding = IISBindings.Ftp;
        }
    }
}
