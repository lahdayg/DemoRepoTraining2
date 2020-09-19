using DemoLearnwithpride.PageObject;
using System;
using TechTalk.SpecFlow;

namespace DemoLearnwithpride.StepDefinition
{
    [Binding]
    public class DataDrivenWithExampleSteps
    {

        DataDrivenWithExamplePage dataDrivenWithExamplePage;

        public DataDrivenWithExampleSteps()
        {
            dataDrivenWithExamplePage = new DataDrivenWithExamplePage();
        }

        [Given(@"the User navigate to ""(.*)""")]
        public void GivenTheUserNavigateTo(string url)
        {
            dataDrivenWithExamplePage.NavigateToWebsite(url);
        }
        
        [Given(@"the User click on create account")]
        public void GivenTheUserClickOnCreateAccount()
        {
            dataDrivenWithExamplePage.ClickOnCreateAccount();
        }
        
        [Given(@"the User enter first name ""(.*)""")]
        public void GivenTheUserEnterFirstName(string Firstname)
        {
            dataDrivenWithExamplePage.EnterFirstName(Firstname);
        }
        
        [Given(@"the User enter last name ""(.*)""")]
        public void GivenTheUserEnterLastName(string Lastname)
        {
            dataDrivenWithExamplePage.EnterLastName(Lastname);
        }
        
        [Given(@"the User enter email address ""(.*)""")]
        public void GivenTheUserEnterEmailAddress(string Email)
        {
            dataDrivenWithExamplePage.EnterEmailAddress(Email);
        }
        
        [Given(@"the User click on the drop down arrow")]
        public void GivenTheUserClickOnTheDropDownArrow()
        {
            dataDrivenWithExamplePage.ClickOnDropDown();
        }
        
        [Given(@"the User select the country")]
        public void GivenTheUserSelectTheCountry()
        {
            dataDrivenWithExamplePage.ClickOnCountry();
        }
        
        [Given(@"the User enter mobile number ""(.*)""")]
        public void GivenTheUserEnterMobileNumber(String Mobile)
        {
            dataDrivenWithExamplePage.EnterMobileNumber(Mobile);
        }
        
        [Given(@"the User enter password ""(.*)""")]
        public void GivenTheUserEnterPassword(String Password1)
        {
            dataDrivenWithExamplePage.EnterPassword(Password1);
        }
        
        [Given(@"the User confirm password ""(.*)""")]
        public void GivenTheUserConfirmPassword(String Password2)
        {
            dataDrivenWithExamplePage.EnterConfirmPassword(Password2);
        }
    }
}
