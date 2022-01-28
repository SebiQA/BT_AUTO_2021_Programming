using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022
{
    class Coookie
    {
        IWebDriver driver;

        public void RegistrationPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        const string protocol = "http";
        const string hostname = "86.121.249.150";
        const string port = "4999";
        const string path = "/#/cookie";

        string url = protocol + "://" + hostname + ":" + port + path;

        const string gibberish = "text-muted"; // class
        const string setthecookie = "set-cookie"; // id
        const string removethecookie = "delete-cookie"; // id
        const string cookieValue = "cookie-value"; //id
        string cValue;


        [SetUp]

        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]

        public void Cookietest()
        {
            driver.Navigate().GoToUrl(url);

            var pageText = driver.FindElement(By.ClassName(gibberish));
            Assert.AreEqual("The gibberish talking cookie", pageText.Text);

            driver.FindElement(By.Id(setthecookie)).Click();

            var coookies = driver.Manage().Cookies;
            Console.WriteLine("The site contains {0} cookies", coookies.AllCookies.Count);
            foreach (Cookie b in coookies.AllCookies)
            {
                Console.WriteLine("Cookie name {0} - cookie value {1}", b.Name, b.Value);
                cValue = b.Value;
            }


            var cookieV = driver.FindElement(By.Id(cookieValue));
            Assert.AreEqual(cValue, cookieV.Text);

            driver.FindElement(By.Id(removethecookie)).Click();

            var ckValue = driver.FindElement(By.Id(cookieValue));
            Assert.AreEqual("", ckValue.Text);

        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
