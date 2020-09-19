using DemoLearnwithpride.PageObject;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace DemoLearnwithpride.StepDefinition
{
    [Binding]
    public class RegistrationSteps
    {
        RegistrationPage registrationPage;

        public RegistrationSteps()
        {
            registrationPage = new RegistrationPage();
        }





        [Given(@"I navigate to www\.amazon\.co\.uk")]
        public void GivenINavigateToWww_Amazon_Co_Uk()
        {
            registrationPage.NavigateToWebsite();
        }
        
        [Given(@"I click on Hello Sign In")]
        public void GivenIClickOnHelloSignIn()
        {
            registrationPage.ClickOnHelloSignIn();
        }
        
        [Given(@"I click on create your amazon account")]
        public void GivenIClickOnCreateYourAmazonAccount()
        {
           registrationPage.ClickOnCreateAmazonAccount();
        }
        
        [Given(@"I enter my name")]
        public void GivenIEnterMyName()
        {
            registrationPage.EnterYourName();
        }
        
        [Given(@"I enter my email")]
        public void GivenIEnterMyEmail()
        {
            registrationPage.EnterEmail();
        }
        
        [Given(@"I enter my password")]
        public void GivenIEnterMyPassword()
        {
            registrationPage.EnterPassword();
        }
        
        [Given(@"I re-enter my password")]
        public void GivenIRe_EnterMyPassword()
        {
            registrationPage.EnterReEnterPassword();
        }
        
        [When(@"I click on create your amazon account in the registration page")]
        public void WhenIClickOnCreateYourAmazonAccountInTheRegistrationPage()
        {
            registrationPage.ClickOnCreateAmazonAccount1();
        }

        [Then(@"my account should be created")]
        public void ThenMyAccountShouldBeCreated()
        {
            //Nunit Assertion
            Assert.That(registrationPage.IsUserLoginIdDisplayed);
        }


        // Random Steps

        [When(@"I enter Username text ""(.*)""")]
        public void WhenIEnterUsernameText(string username)
        {
            registrationPage.EnterUsername(username);
        }

        [When(@"I enter email text ""(.*)""")]
        public void WhenIEnterEmailText(string emailtxt)
        {
            registrationPage.EnterEmail(emailtxt);
        }

        [When(@"I enter password text ""(.*)""")]
        public void WhenIEnterPasswordText(string password)
        {
            registrationPage.EnterPassword(password);
        }

        [When(@"I click on sign up button")]
        public void WhenIClickOnSignUpButton()
        {
            registrationPage.ClickSignUpButton();
        }





    }
}
