using System;
using System.Collections.Generic;
using System.Text;
using NUnit_Auto_2022.Page_models.POM;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace NUnit_Auto_2022.PageModels.POM
{
    public class RegisterPage : BasePage
    {
        const string registerTextSelector = "text-muted"; // class

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

        internal void Registration(string username, string password, string passconfirm, string firstName, string lastName, string email, string dob, SelectElement nationality)
        {
            throw new NotImplementedException();
        }

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

        public RegisterPage(IWebDriver driver) : base(driver)
        {
        }

        public string CheckPage()
        {
            return driver.FindElement(By.ClassName(registerTextSelector)).Text;
        }

        public void Registration(string user, string pass, string passConfirm, string firstname, string lastname, string email, string dob, string nationality)
        {

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
            submit.Submit();
        }
    }
}
