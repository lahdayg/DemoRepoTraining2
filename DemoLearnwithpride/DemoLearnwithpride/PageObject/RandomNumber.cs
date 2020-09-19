using DemoLearnwithpride.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLearnwithpride.PageObject
{
    class RandomNumber
    {
        public RandomNumber()
        {
            driver = Hooks1.driver;
        }


        IWebDriver driver;


        IWebElement usernameInput => driver.FindElement(By.XPath("//input[@placeholder = 'Username']"));

        IWebElement emailInput => driver.FindElement(By.XPath("//input[@placeholder = 'Email']"));

        IWebElement passwordInput => driver.FindElement(By.XPath("//input[@placeholder = 'Password']"));

        IWebElement signUpButton => driver.FindElement(By.XPath("//button[@type='submit']"));

        IWebElement userLogin => driver.FindElement(By.XPath("//a[@class='nav-link ng-binding']"));











        public void EnterUsername(string username)
        {
           
            usernameInput.SendKeys(username);
        }

        public void EnterEmail(string amala)
        {
            
            emailInput.SendKeys(amala);
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
            return userLogin.Displayed;
        }

        //public void NavigateToWebsite(string url)
        //{
        //    driver.Navigate().GoToUrl(url);
        //}


    }
}



 
