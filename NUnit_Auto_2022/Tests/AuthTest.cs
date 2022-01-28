using NUnit.Framework;
using NUnit_Auto_2022.Page_models.POM;
using NUnit_Auto_2022.Page_models.PageFactory;
using NUnit_Auto_2022.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.Page_models
{
    class AuthTest
    {
        IWebDriver driver;

        string url = FrameworkConstants.GetUrl();


        [SetUp]

        public void Setup()
        {
            driver = new ChromeDriver();
        }

        //Test authentication with Page Object Model
        [Test]
        public void BasicAuth()
        {
            driver.Navigate().GoToUrl(url + "login");
            Page_models.POM.LoginPage lp = new Page_models.POM.LoginPage(driver);
            Assert.AreEqual("Authentication", lp.CheckPage());
            lp.Login("user1", "pass1");

        }

        //Test authentication with Page Factory

       [Test]

       public void BasicAuthPf()
        {
            driver.Navigate().GoToUrl(url + "login");
            Page_models.PageFactory.LoginPage lp = new Page_models.PageFactory.LoginPage(driver);
            Assert.AreEqual("Authentication", lp.CheckPage());
            lp.Login("user1", "pass1");

        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }


    }
}
