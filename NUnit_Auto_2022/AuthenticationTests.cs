﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022
{
    class AuthenticationTests
    {
        IWebDriver driver;

        const string protocol = "http";
        const string hostname = "86.121.249.150";
        const string port = "4999";
        const string path = "/#/";

        string url = protocol + "://" + hostname + ":" + port + path;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
        }

        [TestCase("dinosaur", "dinosaurpassword", "", "")]
        [TestCase("dinosaur", "", "", "Password is required!")]
        [TestCase("", "", "Username is required!", "Password is required!")]
        [TestCase("", "dinosaurpassword", "Username is required!", "")]

        public void Test01(string user, string pass, string userErr, string passErr)
        {
            driver.Navigate().GoToUrl(url);

            //facem un assert de fiecare data cand mergem pe o pagina sa ne asiguram ca suntem pe pagina care trebuie - recomandat de fiecare data
            var pageText = driver.FindElement(By.CssSelector("#root > div > div.content > div > div:nth-child(1) > div > div > h1 > small"));
            Assert.AreEqual("Home", pageText.Text);

            var loginLink = driver.FindElement(By.CssSelector("#root > div > div.sidebar > a:nth-child(2)"));
            loginLink.Click();
            Console.WriteLine(loginLink.GetAttribute("href"));

            pageText = driver.FindElement(By.CssSelector("#root > div > div.content > div > div:nth-child(1) > div > div > h1 > small"));
            Assert.AreEqual("Authentication", pageText.Text);

            var username = driver.FindElement(By.Id("input-login-username"));
            var password = driver.FindElement(By.Id("input-login-password"));
            var submit = driver.FindElement(By.CssSelector("#login-form > div:nth-child(3) > div.text-left.col-lg > button"));

            var usernameError = driver.FindElement(By.CssSelector("#login-form > div:nth-child(1) > div > div > div.text-left.invalid-feedback"));
            var passwordError = driver.FindElement(By.CssSelector("#login-form > div.form-group.row.row-cols-lg-true > div > div > div.text-left.invalid-feedback"));

            username.Clear();
            username.SendKeys(user);

            password.Clear();
            password.SendKeys(pass);

            submit.Submit();

            Assert.AreEqual(userErr, usernameError.Text);
            Assert.AreEqual(passErr, passwordError.Text);

        }

        //implicit wait test (se pune la nivel browser)
        [Test]
        public void Test02()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            string url = protocol + "://" + hostname + ":8081/lazy.html";
            driver.Navigate().GoToUrl(url);

            var button1 = driver.FindElement(By.Id("btn1"));
            button1.Click();
        }

        //explicit wait test (se pune la nivelul elementului dupa care asteptam)
        [Test]
        public void Test03()
        {
            string url = protocol + "://" + hostname + ":8081/lazy.html";
            driver.Navigate().GoToUrl(url);

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            //var button1 = driver.FindElement(By.Id("btn1"));
            var button1 = Utils.WaitForElement(driver, 20, By.Id("btn1"));
            button1.Click();

        }

        [Test]
        public void Test04()
        {
            string url = protocol + "://" + hostname + ":8081/lazy.html";
            driver.Navigate().GoToUrl(url);

            var button2 = Utils.WaitForElement(driver, 15, By.Id("btn2"));
            for (int i = 0; i < 100; i++)
            {
                button2.Click();
            }

        }

        [Test]
        public void Test05()
        {
            string url = protocol + "://" + hostname + ":8081/lazy.html";
            driver.Navigate().GoToUrl(url);

            var element = Utils.WaitForFluentElement(driver, 20, By.Id("btn2"));
            element.Click();
        }


        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
    
}
