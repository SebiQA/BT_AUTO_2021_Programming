using NUnit.Framework;
using NUnit_Auto_2022.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.Tests
{
    class BaseTest
    {
        public IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            //instantiate the browser using the Browser Factory class in Utilities
            driver = Browser.GetDriver(webBrowsers.Edge);
        }


        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

    }
}
