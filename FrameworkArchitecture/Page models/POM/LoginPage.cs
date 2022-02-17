using NUnit_Auto_2022.Page_models.POM;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.PageModels.POM
{
    class LoginPage : BasePage
    {

        const string authPageText = "text-muted"; // class
        const string usernameLabel = "label.col-lg"; // css
        const string usernameInput = "input-login-username"; //id
        const string usernameError = "div.form-group:nth-child(1) > div:nth-child(2) > div:nth-child(1) > div:nth-child(3)"; // css
        const string passwordLabel = "label.col"; // css
        const string passwordInput = "input-login-password"; // id
        const string passwordError = "div.form-group:nth-child(2) > div:nth-child(2) > div:nth-child(1) > div:nth-child(3)"; // css
        const string submitButton = "btn-primary"; // class

        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        public string CheckPage()
        {
            var authPageEl = driver.FindElement(By.ClassName(authPageText));
            return authPageEl.Text;
        }

        public void Login(string user, string passw)
        {
            var usernameInputElement = driver.FindElement(By.Id(usernameInput));
            usernameInputElement.Clear();
            usernameInputElement.SendKeys(user);
            var passwordInputElement = driver.FindElement(By.Id(passwordInput));
            passwordInputElement.Clear();
            passwordInputElement.SendKeys(passw);
            var submitButtonElement = driver.FindElement(By.ClassName(submitButton));
            submitButtonElement.Submit();
        }

    }
}