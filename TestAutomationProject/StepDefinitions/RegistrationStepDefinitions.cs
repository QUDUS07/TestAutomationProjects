using System;
using TechTalk.SpecFlow;
using TestAutomationProject.PageObject;

namespace TestAutomationProject.StepDefinitions
{
    [Binding]
    public class RegistrationStepDefinitions
    {
        RegistrationPage registrationPage;
        public RegistrationStepDefinitions () 
        {
            registrationPage= new RegistrationPage ();  
        }





        [Given(@"I navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
           registrationPage.NavigateToWebsite ();
        }

        [Given(@"I click on Sign up")]
        public void GivenIClickOnSignUp()
        {
            registrationPage.ClickSignUp();
        }

        [Given(@"I enter Username")]
        public void GivenIEnterUsername()
        {
            registrationPage.EnterUserName ();
        }

        [Given(@"I enter Email")]
        public void GivenIEnterEmail()
        {
            registrationPage.EnterEmail();
        }

        [Given(@"I enter password")]
        public void GivenIEnterPassword()
        {
            registrationPage.EnterPassword();
        }

        [When(@"I click on the sign up botton")]
        public void WhenIClickOnTheSignUpBotton()
        {
            registrationPage.ClickSignUpButton();
        }

        [Then(@"I should be able to register successfully")]
        public void ThenIShouldBeAbleToRegisterSuccessfully()
        {
            registrationPage.IsNewArticleDisplaced();
        }
    }
}
