using DemoLearnwithpride.PageObject;
using System;
using TechTalk.SpecFlow;

namespace DemoLearnwithpride.StepDefinition
{
    [Binding]
    public class DataDrivenWithParameterizationSteps
    {
        DataDrivenWithParameterPage dataDrivenWithParameterPage;

        public DataDrivenWithParameterizationSteps()
        {
            dataDrivenWithParameterPage = new DataDrivenWithParameterPage();
        }




        [Given(@"I navigae to ""(.*)""")]
        public void GivenINavigaeTo(string url)
        {
            dataDrivenWithParameterPage.NavigateToWebsite(url);

        }

        
        [Given(@"I click on create account")]
        public void GivenIClickOnCreateAccount()
        {
            dataDrivenWithParameterPage.ClickOnCreateAccount();
        }
        
        [Given(@"I enter my first name ""(.*)""")]
        public void GivenIEnterMyFirstName(string fname)
        {
           dataDrivenWithParameterPage.EnterFirstName(fname);
        }
        
        [Given(@"I enter my last name ""(.*)""")]
        public void GivenIEnterMyLastName(string lname)
        {
            dataDrivenWithParameterPage.EnterLastName(lname);

        }
        
        [Given(@"I enter my email address ""(.*)""")]
        public void GivenIEnterMyEmailAddress(string email)
        {
            dataDrivenWithParameterPage.EnterEmailAddress(email);
        }
        
        [Given(@"I click on the drop down arrow")]
        public void GivenIClickOnTheDropDownArrow()
        {
            dataDrivenWithParameterPage.ClickOnDropDown();
        }
        
        [Given(@"I select the country")]
        public void GivenISelectTheCountry()
        {
            dataDrivenWithParameterPage.ClickOnCountry();
        }
        
        [Given(@"I enter my mobile number ""(.*)""")]
        public void GivenIEnterMyMobileNumber(string mobile)
        {
            dataDrivenWithParameterPage.EnterMobileNumber(mobile);
        }
        
        [Given(@"I enter my password ""(.*)""")]
        public void GivenIEnterMyPassword(string pwd)
        {
            dataDrivenWithParameterPage.EnterPassword(pwd);
        }
        
        [Given(@"I confirm password ""(.*)""")]
        public void GivenIConfirmPassword(string pwd2)
        {
            dataDrivenWithParameterPage.EnterConfirmPassword(pwd2);
        }
        
        [When(@"I click on Register button")]
        public void WhenIClickOnRegisterButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be registered")]
        public void ThenIShouldBeRegistered()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
