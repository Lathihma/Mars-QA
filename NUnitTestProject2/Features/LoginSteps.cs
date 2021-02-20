using DocumentFormat.OpenXml.Drawing;
using NUnitTestProject2.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Table = TechTalk.SpecFlow.Table;

namespace NUnitTestProject2.Features
{
    [Binding]
    
    public class LoginSteps
    {
        LoginPage loginpage = null;

        // step definitions
        [Given(@"launch the application")]
        public void GivenLaunchTheApplication()
        {
            IWebDriver webdriver = new ChromeDriver();
            webdriver.Navigate().GoToUrl("http://localhost:5000/");
            loginpage = new LoginPage(webdriver);
        }

        [Given(@"Click on login button")]
        public void GivenClickOnLoginButton()
        {
            loginpage.ClickLogin();
        }

        [Given(@"Enter the following details")]
        public void GivenEnterTheFollowingDetails(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            loginpage.Login((string)data.Emailaddress, (string)data.Password);
        }

        [Given(@"click on login button")]
        public void GivenIClickOnLoginButton()
        {
            loginpage.ClickLoginButton();
        }

       
    }
}

