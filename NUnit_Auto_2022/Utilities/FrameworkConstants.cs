using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.Utilities
{
    public class FrameworkConstants
    {
        const string protocol = "http";
        const string hostname = "86.121.249.150";
        const string port = "4999";
        const string path = "/#/";
        const string extensionPath = "Other\\ExtensionFile";

        public const bool startHeadless = false;
        public const bool useProxy = false;
        public const bool startMaximized = false;
        public const bool ignoreCerterr = true;
        public const string browserProxy = "127.0.0.1:8080";
        public const bool startWithExtension = false;


        public static String GetUrl()
        {
            return String.Format("{0}://{1}:{2}{3}", protocol, hostname, port, path);
        }

        public static string GetExtensionName(webBrowsers browserType)
        {
            switch (browserType) 
            {
                case webBrowsers.Firefox:
                    {
                        return string.Format("{0}\\ metamask-10.8.1-an+fx.xpi", extensionPath);
                    }
                default:
                    {
                        return string.Format("{0} extension_4_42_0_0.crx", extensionPath);
                    }
            }

        }
    }
}
