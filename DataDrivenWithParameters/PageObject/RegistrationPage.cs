using DataDrivenWithParameters.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrivenWithParameters.PageObject
{
     class RegistrationPage
    {
        public RegistrationPage() 
        {
            driver = Hooks1.driver;
        }
        IWebDriver driver;

        IWebElement SignUp => driver.FindElement(By.XPath("(//a[@ui-sref=\"app.register\"])[1]"));
        IWebElement Username => driver.FindElement(By.XPath("//input[@ng-model=\"$ctrl.formData.username\"]"));
        IWebElement Email => driver.FindElement(By.XPath("//input[@class=\"form-control form-control-lg ng-pristine ng-untouched ng-valid ng-empty ng-valid-email\"]"));
        IWebElement Password => driver.FindElement(By.XPath("//input[@type=\"password\"]"));
        IWebElement SignUpButton => driver.FindElement(By.XPath("//button[@ng-bind=\"$ctrl.title\"]"));
        IWebElement Settings => driver.FindElement(By.XPath("//a[@ui-sref=\"app.settings\"]"));



        public void NavigateToWebSite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
        public void ClickOnSignUp()
        {
            SignUp.Click();
        }
        public void EnterUsername(string username) 
        {
            Username.SendKeys(username);
        }
        public void EnterEmail(string email) 
        {
            Email.SendKeys(email);
        }
        public void EnterPassword(string password)
        {
            Password.SendKeys(password);
        }
        public void ClickOnSignUpButton()
        { 
            SignUpButton.Click(); 
        }
        public bool IsSettingsDisplayed()
        {
            return Settings.Displayed;
        }










    }
}
