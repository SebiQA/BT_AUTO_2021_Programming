using NUnit.Framework;
using NUnit_Auto_2022.Page_models.POM;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.Tests
{
    class EcomTestSite
    {

        IWebDriver driver;


        //https://www.abdcomputer.ro/

        [SetUp]

        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.abdcomputer.ro/");
        }

        [Test]
        public void LoginTest()
        {
            LandingPage lp = new LandingPage(driver);
            Assert.AreEqual("Produse IT Renew, Refurbish, Noi & SH", lp.CheckPage());
            lp.LoginNavigate();
        }




        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

    }
}
