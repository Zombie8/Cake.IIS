using Cake.IIS.Bindings;

namespace Cake.IIS.Settings
{
    public class WebsiteSettings : SiteSettings
    {
        public WebsiteSettings()
            : base()
        {
            Binding = IISBindings.Http;
        }
    }
}