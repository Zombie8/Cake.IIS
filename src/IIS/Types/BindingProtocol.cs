using System;

namespace Cake.IIS
{
    public class BindingProtocol
    {
        private BindingProtocol(string name)
        {
            this.Name = name;
        }

        private string Name { get; set; }

        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString() => this.Name;

        /// <value>
        /// <see cref="BindingProtocol"/> for <c>ftp</c> IIS binding type.
        /// </value>
        public static BindingProtocol Ftp => new BindingProtocol(Uri.UriSchemeFtp);

        /// <value>
        /// <see cref="BindingProtocol"/> for <c>http</c> IIS binding type.
        /// </value>
        public static BindingProtocol Http => new BindingProtocol(Uri.UriSchemeHttp);

        /// <value>
        /// <see cref="BindingProtocol"/> for <c>https</c> IIS binding type.
        /// </value>
        public static BindingProtocol Https => new BindingProtocol(Uri.UriSchemeHttps);

        /// <value>
        /// <see cref="BindingProtocol"/> for <c>net.tcp</c> IIS binding type.
        /// </value>
        public static BindingProtocol NetTcp => new BindingProtocol(Uri.UriSchemeNetTcp);

        /// <value>
        /// <see cref="BindingProtocol"/> for <c>net.pipe</c> IIS binding type.
        /// </value>
        public static BindingProtocol NetPipe => new BindingProtocol(Uri.UriSchemeNetPipe);

        /// <value>
        /// <see cref="BindingProtocol"/> for <c>net.msmq</c> IIS binding type.
        /// </value>
        public static BindingProtocol NetMsmq => new BindingProtocol("net.msmq");

        /// <summary>
        /// <see cref="BindingProtocol"/> for <c>msmq.formatname</c> IIS binding type.
        /// </summary>
        public static BindingProtocol MsmqFormatName => new BindingProtocol("msmq.formatname");
    }
}
