﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.Utilities
{
    public class Browser
    {

        public static IWebDriver GetDriver(webBrowsers browserType)
        {
            switch (browserType) 
            {
                // Instantiate a chrome driver
                case webBrowsers.Chrome:
                    {
                        var options = new ChromeOptions();
                        //options for the driver based on flags from FrameWorkConstants
                        if (FrameworkConstants.startMaximized)
                        {
                            options.AddArgument("--start-maximized");
                        }
                 
                        if (FrameworkConstants.startHeadless)
                        {
                            options.AddArgument("headless");
                        }
                        if (FrameworkConstants.ignoreCerterr)
                        {
                            options.AddArgument("ignore-certificate-errors");
                        }
                        //proxy definition
                        var proxy = new Proxy
                        {
                            HttpProxy = FrameworkConstants.browserProxy,
                            IsAutoDetect = false
                        };
                        if (FrameworkConstants.useProxy)
                        {
                            options.Proxy = proxy;
                        }
                        //initiate chrome driver with options
                        return new ChromeDriver(options);
                    }
                case webBrowsers.Firefox:
                    {
                        //options for the driver based on flags from FrameWorkConstants
                        var firefoxOptions = new FirefoxOptions();
                        List<string> optionList = new List<string>();
                        if (FrameworkConstants.startHeadless)
                        {
                            optionList.Add("--headless");
                        }
                        if (FrameworkConstants.ignoreCerterr) 
                        {
                            optionList.Add("--ignore-certificate-errors");
                        }

                        firefoxOptions.AddArguments(optionList);
                        FirefoxProfile fProfile = new FirefoxProfile();

                        //Adding extension if the oprion is enable in FrameworkConstants
                        if (FrameworkConstants.startWithExtension)
                        {
                            fProfile.AddExtension(FrameworkConstants.GetExtensionName(browserType));
                        }
                        firefoxOptions.Profile = fProfile;

                        //initiate the Firefox driver with options
                        return new FirefoxDriver(firefoxOptions);
                    }
                case webBrowsers.Edge:
                    {

                        var edgeOptions = new EdgeOptions();
                        //edgeOptions.AddExtension("C:\\Users\\Sebastian\\Downloads\\extension_4_42_0_0.crx");
                        //edgeOptions.AddArguments("args", "['start-maximized', 'headless']");
                        if (FrameworkConstants.startMaximized)
                        {
                            edgeOptions.AddArguments("--start-maximized");
                        }
                        if (FrameworkConstants.startHeadless)
                        {
                            edgeOptions.AddArguments("headless");
                        }
                        if (FrameworkConstants.startWithExtension)
                        {
                            edgeOptions.AddExtension(FrameworkConstants.GetExtensionName(browserType));
                        }
                        return new EdgeDriver(edgeOptions);
                    }

                    // if the specified browser is not implemented
                default:
                    {
                        throw new BrowserTypeException(browserType.ToString());
                    }
            }
        }

    }

    //browser Enum with the supported browser types
    public enum webBrowsers
    {
        Chrome,
        Firefox,
        Edge
    }
}