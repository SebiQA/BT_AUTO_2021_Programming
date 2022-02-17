using NUnit_Auto_2022.Page_models.POM;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.PageModels.POM
{
    public class LandingPage : BasePage
    {
        const string checkPageSelector = "text-muted"; // class

        const string loginButtonSelector = "a.nav-link:nth-child(2)"; // css
        const string registrationButtonSelector = "a.nav-link:nth-child(3)"; // css

        public LandingPage(IWebDriver driver) : base(driver)
        {
      
        }

        public string CheckPage()
        {
            return driver.FindElement(By.ClassName(checkPageSelector)).Text;
        }

        public void LoginNavigate()
        {
            var authButtn = driver.FindElement(By.CssSelector(loginButtonSelector));
            authButtn.Click();
            var authArea = driver.FindElement(By.ClassName(loginButtonSelector));
            var registerAccElement = authArea.FindElement(By.CssSelector(registrationButtonSelector));
            registerAccElement.Click();
        }
    }
}