using DataDrivenWithParameters.PageObject;
using NuGet.Frameworks;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace DataDrivenWithParameters.StepDefinitions
{
    [Binding]
    public class RegistrationStepDefinitions
    {

        RegistrationPage registrationPage;
        public RegistrationStepDefinitions() 
        { 
            registrationPage= new RegistrationPage();   
        }


        [Given(@"I navigate ""([^""]*)""")]
        public void GivenINavigate(string url)
        {
            registrationPage.NavigateToWebSite(url);
        }

        [Given(@"I click on the SignUp")]
        public void GivenIClickOnTheSignUp()
        {
            registrationPage.ClickOnSignUp();
        }

        [Given(@"I enter my Username ""([^""]*)""")]
        public void GivenIEnterMyUsername(string username)
        {
            registrationPage.EnterUsername(username);
        }

        [Given(@"I enter my Email ""([^""]*)""")]
        public void GivenIEnterMyEmail(string email)
        {
            registrationPage.EnterEmail(email);
        }

        [Given(@"I enter my Password ""([^""]*)""")]
        public void GivenIEnterMyPassword(string password)
        {
            registrationPage.EnterPassword(password);
        }

        [When(@"I click on SignUp button")]
        public void WhenIClickOnSignUpButton()
        {
            registrationPage.ClickOnSignUpButton();
        }

        [Then(@"I should be able to register successfully")]
        public void ThenIShouldBeAbleToRegisterSuccessfully()
        {
            Thread.Sleep(5000);
            Assert.That(registrationPage.IsSettingsDisplayed);
        }
    }
}
