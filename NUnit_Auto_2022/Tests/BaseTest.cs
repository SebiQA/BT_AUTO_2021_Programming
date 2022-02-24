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
        public static string conDetails;

        // Before each test
        [SetUp]
        public void Setup()
        {
            // Instatiate the browser using the Browser Factory class created in Utilities
            driver = Browser.GetDriver();

            // Read the encrypted connection string (server=;user=;password=;port=;database=) from json in conDetails variable
           


        }

        // After each test
        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}