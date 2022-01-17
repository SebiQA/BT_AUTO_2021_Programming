﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022
{
    class SeleniumTests

    {
        //public string path = "C:\\drivers";
        IWebDriver driver;
        const string protocol = "https";
        const string hostname = "magazinulcolectionarului.ro";
        const string path = "/";

        string url = protocol + "://" + hostname + path;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            //driver = new FirefoxDriver();
            //driver = new EdgeDriver();
           
        }

        [Test]
        public void Test1()
        {
            driver.Url = url;
            driver.Navigate();

            //echivalent cu:
            //driver.Navigate().GoToUrl(url);

            driver.Navigate().Back();
            driver.Navigate().Forward();
            driver.Navigate().Refresh();

        }
        [Test]
        public void Test2()
        {
            driver.Url = "https://learn.digitalstack.ro";
            driver.Navigate();
        }

        [Test]
        public void Test3()
        {
            driver.Url = url;
            driver.Navigate();

            IWebElement body = driver.FindElement(By.ClassName("modal-header"));
            body.Click();

            IWebElement eaglemoss = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[2]/nav/div/ul/li[1]/a/span[2]"));
            eaglemoss.Click();

            var addToCart = driver.FindElements(By.XPath("html/body/div[2]/main/div[3]/div[1]/div[4]/div[2]/ol/li"));
            foreach(IWebElement el in addToCart)
            {
                var text = el.FindElement(By.XPath("//span"));
                Console.WriteLine(text.Text);
            }
        }


        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }



    }
}
