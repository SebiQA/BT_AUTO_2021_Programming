using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.PageModels.POM
{
    public class LandingPage
    {
        const string authButtonSelector = "#top-nav > div > div.navbar-collapse.collapse.navbar-right > ul > li:nth-child(2) > a > span.fa.fa-user"; // css
        const string authPopupSelector = "nav-stacked"; // class
        const string registerAccLinkSelector = "ul > li:nth-child(2) > a"; // css
        const string myCartSelector = "cart-count-withtext"; // class
        const string myCartAreaSelector = "cart-content"; // class
        const string myCartButtonSelector = "div"; // tag name
        const string searchBoxSelector = "search-box"; // id
        const string serachButtonSelector = "btn-primary"; // class
        const string checkPageSelector = "h1"; // tag

        IWebDriver driver;

        public LandingPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string CheckPage()
        {
            return driver.FindElement(By.TagName(checkPageSelector)).Text;
        }

        public void LoginNavigate()
        {
            var authButtn = driver.FindElement(By.CssSelector(authButtonSelector));
            authButtn.Click();
            var authArea = driver.FindElement(By.ClassName(authPopupSelector));
            var registerAccElement = authArea.FindElement(By.CssSelector(registerAccLinkSelector));
            registerAccElement.Click();
        }
    }
}