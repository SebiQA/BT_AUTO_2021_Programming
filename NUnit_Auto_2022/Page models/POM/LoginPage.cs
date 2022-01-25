﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.Page_models.POM
{
    class LoginPage
    {
        const string authPageText = "text-muted"; //class
        const string usernameLabel = "#login-form > div:nth-child(1) > label"; //css
        const string usernameInput = "input-login-username"; //Id
        const string usernameError = "#login-form > div:nth-child(1) > div > div > div.text-left.invalid-feedback"; //css
        const string passwordLabel = "#login-form > div.form-group.row.row-cols-lg-true > label"; // css
        const string passwordInput = "input-login-password"; //Id
        const string passwordError = "#login-form > div.form-group.row.row-cols-lg-true > div > div > div.text-left.invalid-feedback"; //css
        const string submitButton = "btn-primary"; //class

        IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string CheckPage()
        {
            var authPageEl = driver.FindElement(By.ClassName(authPageText));
            return authPageEl.Text; 
        }

        public void Login(string user,string passw)
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