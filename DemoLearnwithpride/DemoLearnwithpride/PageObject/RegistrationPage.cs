using DemoLearnwithpride.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DemoLearnwithpride.PageObject
{
    class RegistrationPage
    {

        public RegistrationPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;


        IWebElement helloSignIn => driver.FindElement(By.XPath("//span[text()='Hello, Sign in']"));

        IWebElement createAmazonAccount => driver.FindElement(By.Id("createAccountSubmit"));

        IWebElement yourName => driver.FindElement(By.CssSelector("#ap_customer_name"));

        IWebElement email => driver.FindElement(By.Name("email"));

        IWebElement password => driver.FindElement(By.XPath("//input[@id='ap_password']"));

        IWebElement reEnterPassword => driver.FindElement(By.XPath("//input[@name='passwordCheck']"));

        IWebElement createAmazonAccount1 => driver.FindElement(By.XPath("//input[@class='a-button-input']"));

        IWebElement userLogin => driver.FindElement(By.XPath("//span[text()='Hello, Demo']"));


        //Random Elements


        IWebElement usernameInput => driver.FindElement(By.XPath("//input[@placeholder = 'Username']"));

        IWebElement emailInput => driver.FindElement(By.XPath("//input[@placeholder = 'Email']"));

        IWebElement passwordInput => driver.FindElement(By.XPath("//input[@placeholder = 'Password']"));

        IWebElement signUpButton => driver.FindElement(By.XPath("//button[@type='submit']"));

        IWebElement userLoginId => driver.FindElement(By.XPath("//a[@class='nav-link ng-binding']"));











        public void ClickOnHelloSignIn()
        {
            Thread.Sleep(5000);
            helloSignIn.Click();
        }

        public void ClickOnCreateAmazonAccount()
        {
            Thread.Sleep(5000);
            createAmazonAccount.Click();
        }

        public void EnterYourName()
        {
            Thread.Sleep(5000);
            yourName.SendKeys("Sikira");
        }

        public void EnterEmail()
        {
            Thread.Sleep(5000);
            email.SendKeys("info@learnwithpride.co.uk");
        }

        public void EnterPassword()
        {
            Thread.Sleep(5000);
            password.SendKeys("PasswordSecure");
        }

        public void EnterReEnterPassword()
        {
            Thread.Sleep(5000);
            reEnterPassword.SendKeys("PasswordSecure");
        }

        public void ClickOnCreateAmazonAccount1()
        {
            Thread.Sleep(5000);
            createAmazonAccount1.Click();
        }

        public bool IsUserLoginIdDisplayed()
        {
            return userLogin.Displayed;
        }


        //Random Methods

        public void EnterUsername(string username)
        {

            usernameInput.SendKeys(username);
        }

        public void EnterEmail(string emailtxt)
        {

            emailInput.SendKeys(emailtxt);
        }

        public void EnterPassword(string password)
        {
            passwordInput.SendKeys(password);
        }

        public void ClickSignUpButton()
        {
            signUpButton.Click();
        }

        public bool IsUserLoginDisplayed()
        {
            return userLoginId.Displayed;
        }






        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://www.amazon.co.uk/");
        }
       
    }
}
