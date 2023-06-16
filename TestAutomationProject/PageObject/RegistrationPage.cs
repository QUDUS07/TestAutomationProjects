using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationProject.Utilities;

namespace TestAutomationProject.PageObject
{
     class RegistrationPage
    {
        public RegistrationPage()
        {
            driver = Hooks1.driver;
        }
             IWebDriver driver;
        IWebElement SignUp => driver.FindElement(By.CssSelector("body > div > app-header > nav > div > ul:nth-child(2) > li:nth-child(3) > a"));
        IWebElement Username => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[1]/input"));
        IWebElement Email => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > fieldset:nth-child(2) > input"));
        IWebElement Password => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > fieldset:nth-child(3) > input"));
        IWebElement SignUpButton => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > button"));
        IWebElement NewArticle => driver.FindElement(By.XPath("(//a[@class='nav-link'])[3]"));
        

        public void ClickSignUp () 
        {
            SignUp.Click(); 
        }

        public void EnterUserName () 
        {
            Username.SendKeys("KEHINDE21");
        }


        public void NavigateToWebsite ()
        {
            driver.Navigate().GoToUrl("https://angularjs.realworld.io/#/");
        }
        public void EnterEmail()
        {
            Email.SendKeys("qudduskehinde4real+4@gmail.com");
        }

        public void EnterPassword () 
        {
            Password.SendKeys("A123456789@");
        }

        public void ClickSignUpButton()
        {
            SignUpButton.Click();
        }


        public bool IsNewArticleDisplaced ()
        {
            return NewArticle.Displayed;
        }




    }
}
