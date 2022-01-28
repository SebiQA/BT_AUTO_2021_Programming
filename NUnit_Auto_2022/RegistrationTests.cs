using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace NUnit_Auto_2022
{
    class RegistrationTests
    {
        IWebDriver driver;

        public void RegistrationPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        const string protocol = "http";
        const string hostname = "86.121.249.150";
        const string port = "4999";
        const string path = "/#/";

        string url = protocol + "://" + hostname + ":" + port + path;

        const string registration = "text-muted"; //class
        const string loginInformation = "div.form-group:nth-child(1) > div:nth-child(2)"; //css
        const string usernameLabel = "div.form-group:nth-child(2) > label:nth-child(1)"; //css
        const string usernameInput = "input-username"; //Id
        const string usernameError = "div.form-group:nth-child(2) > div:nth-child(2) > div:nth-child(1) > div:nth-child(3)"; //css
        const string usernameRequirements = "div.form-group:nth-child(2) > div:nth-child(2) > small:nth-child(2)"; //css
        const string passwordLabel = "div.form-group:nth-child(3) > label:nth-child(1)"; // css
        const string passwordInput = "input-password"; //Id
        const string passwordError = "div.form-group:nth-child(3) > div:nth-child(2) > div:nth-child(1) > div:nth-child(3)"; //css  
        const string passwordRequirements = "div.form-group:nth-child(3) > div:nth-child(2) > small:nth-child(2)"; //css
        const string confirmPasswordLabel = "div.form-group:nth-child(4) > label:nth-child(1)"; //css
        const string confirmPasswordInput = "input-password-confirm"; //id
        const string confirmPasswordRequirements = "div.form-group:nth-child(4) > div:nth-child(2) > small:nth-child(2)"; //css
        const string confirmPasswordError = "div.form-group:nth-child(4) > div:nth-child(2) > div:nth-child(1) > div:nth-child(3)"; //css
        const string someDetails = "div.form-group:nth-child(5) > div:nth-child(2)"; //css
        const string title = "div.form-group:nth-child(6) > label:nth-child(1)"; //css
        const string titleInput = "form-check-input"; //class
        const string firstNameLabel = "div.form-group:nth-child(7) > label:nth-child(1)"; //css
        const string firstNameInput = "input-first-name"; //id
        const string firstNameRequirements = "div.form-group:nth-child(7) > div:nth-child(2) > small:nth-child(2)"; //css
        const string firstNameError = "div.form-group:nth-child(7) > div:nth-child(2) > div:nth-child(1) > div:nth-child(3)"; //css
        const string lastNameLabel = "div.form-group:nth-child(8) > label:nth-child(1)"; //css
        const string lastNameInput = "input-last-name"; //id
        const string lastNameRequirements = "div.form-group:nth-child(8) > div:nth-child(2) > small:nth-child(2)"; //css
        const string lasttNameError = "div.form-group:nth-child(8) > div:nth-child(2) > div:nth-child(1) > div:nth-child(3)"; //css
        const string emailLabel = "div.form-group:nth-child(9) > label:nth-child(1)"; //css
        const string emailInput = "input-email"; //id
        const string emailError = "div.form-group:nth-child(9) > div:nth-child(2) > div:nth-child(1) > div:nth-child(3)"; //css
        const string spamInfo = "div.form-group:nth-child(9) > div:nth-child(2) > small:nth-child(2)"; //css
        const string dobLabel = "div.form-group:nth-child(10) > label:nth-child(1)"; //css
        const string dobInput = "input-dob"; //id
        const string nationalityLabel = "div.form-group:nth-child(11) > label:nth-child(1)"; //css
        const string nationalityInput = "input-nationality"; //id
        const string tcAgreement = "terms"; //id
        const string tcAgreementError = "registration-form"; //id
        const string submitButton = "btn-primary"; //class

        [SetUp]

        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [TestCase("Sebastian", "", "Sebastian", "", "Sebastian", "", "Parampapam", "", "Filip", "", "sebi_filip07@yahoo.com","", "01/24/2022", "Romanian")]
        [TestCase("", "Username is required!", "", "Password is required!", "pass", "Passwords do not match!", "", "", "F", "Minimum of 2 characters is required!", "", "Email is required!", "", "")]
        [TestCase("Seb", "Minimum of 4 characters is required!", "Seb", "Minimum of 8 characters is required!", "Seb", "", "P", "Minimum of 2 characters is required!", "", "", "pampam@", "Invalid email address!", "", "Greek")]
        public void Registration(string user, string userError, string pass, string passError, string passConfirm, string passConfirmErr, string firstname, string fNameErr, string lastname, string lNameErr, string email, string eErr, string dob, string nationality)
        {
            driver.Navigate().GoToUrl(url + "registration");

            var pageText = driver.FindElement(By.ClassName(registration));
            Assert.AreEqual("Registration", pageText.Text);

            var userNameInputElement = driver.FindElement(By.Id(usernameInput));
            userNameInputElement.Clear();
            userNameInputElement.SendKeys(user);

            var passwordInputElement = driver.FindElement(By.Id(passwordInput));
            passwordInputElement.Clear();
            passwordInputElement.SendKeys(pass);

            var passwordConfirmInputElement = driver.FindElement(By.Id(confirmPasswordInput));
            passwordConfirmInputElement.Clear();
            passwordConfirmInputElement.SendKeys(passConfirm);

            var firstNameInputElement = driver.FindElement(By.Id(firstNameInput));
            firstNameInputElement.Clear();
            firstNameInputElement.SendKeys(firstname);

            var lastNameInputElement = driver.FindElement(By.Id(lastNameInput));
            lastNameInputElement.Clear();
            lastNameInputElement.SendKeys(lastname);

            var emailInputElement = driver.FindElement(By.Id(emailInput));
            emailInputElement.Clear();
            emailInputElement.SendKeys(email);

            var dobInputElement = driver.FindElement(By.Id(dobInput));
            dobInputElement.Clear();
            dobInputElement.SendKeys(dob);

            SelectElement drpNationality = new SelectElement(driver.FindElement(By.Id(nationalityInput)));
            drpNationality.SelectByText(nationality);

            WebElement checkBoxElement = (WebElement)driver.FindElement(By.Id(tcAgreement));
            checkBoxElement.Click();


            var submit = driver.FindElement(By.ClassName(submitButton));

            var usernameErr = driver.FindElement(By.CssSelector(usernameError));
            var passwordErr = driver.FindElement(By.CssSelector(passwordError));
            var passwordConfirmErr = driver.FindElement(By.CssSelector(confirmPasswordError));
            var firstNameErr = driver.FindElement(By.CssSelector(firstNameError));
            var lastNameErr = driver.FindElement(By.CssSelector(lasttNameError));
            var emailErr = driver.FindElement(By.CssSelector(emailError));

            submit.Submit();

            Assert.AreEqual(userError, usernameErr.Text);
            Assert.AreEqual(passError, passwordErr.Text);
            Assert.AreEqual(passConfirmErr, passwordConfirmErr.Text);
            Assert.AreEqual(fNameErr, firstNameErr.Text);
            Assert.AreEqual(lNameErr, lastNameErr.Text);
            Assert.AreEqual(eErr, emailErr.Text);



        }


        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }


    }
}
