using DemoLearnwithpride.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLearnwithpride.PageObject
{
    class DataDrivenWithExamplePage
    {

        public DataDrivenWithExamplePage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;


        IWebElement createaccount => driver.FindElement(By.XPath("(//a[text()='Create account'])[1]"));

        IWebElement firstName => driver.FindElement(By.XPath("//*[@id='first_name']"));

        IWebElement lastName => driver.FindElement(By.XPath("//*[@id='last_name']"));

        IWebElement dropDown => driver.FindElement(By.XPath("//*[@id='nav-register']/form/div[4]/div/div/div"));

        IWebElement emailAddress => driver.FindElement(By.XPath("//*[@id='email']"));

        IWebElement country => driver.FindElement(By.XPath("(//span[text()='United Kingdom'])[1]"));

        IWebElement mobileNumber => driver.FindElement(By.XPath("//*[@id='mobile']"));

        IWebElement password => driver.FindElement(By.XPath("//*[@id='password']"));

        IWebElement confirmPassword => driver.FindElement(By.XPath("//*[@id='confirm_password']"));



        public void ClickOnCreateAccount()
        {
            createaccount.Click();
        }

        public void EnterFirstName(string Firstname)
        {
            firstName.SendKeys(Firstname);
        }

        public void EnterLastName(string Lastname)
        {
            lastName.SendKeys(Lastname);
        }

        public void ClickOnDropDown()
        {
            dropDown.Click();
        }

        public void EnterEmailAddress(string Email)
        {
            emailAddress.SendKeys(Email);
        }

        public void ClickOnCountry()
        {
            country.Click();
        }

        public void EnterMobileNumber(string Mobile)
        {
            mobileNumber.SendKeys(Mobile);
        }

        public void EnterPassword(string Password1)
        {
            password.SendKeys(Password1);
        }

        public void EnterConfirmPassword(string Password2)
        {
            confirmPassword.SendKeys(Password2);
        }


        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }





    }
}






    

