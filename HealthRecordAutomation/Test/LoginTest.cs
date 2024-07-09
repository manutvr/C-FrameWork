using HealthRecordAutomation.Pages;
using KPMG.HealthRecordAutomation.Base;
using KPMG.HealthRecordAutomation.Pages;
using KPMG.HealthRecordAutomation.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V124.Network;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPMG.HealthRecordAutomation.Test
{
    public class LoginTest : AutomationWraper
    {

        //Create static metohod that return object[]

        [Test]
       
        [TestCaseSource(typeof(DataSource),nameof(DataSource.ValidLoginData))]
        
        public void ValidLoginTest(string username, string password, string expectedTittle)
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.EnterUsername(username);
            loginPage.EnterPassword(password);
            loginPage.ClickOnLogin();

            //move the GetMainPageTitle() to MainPage class
            MainPage mainPage = new MainPage(driver);
            string actualTitle = mainPage.GetMainPageTitle();

            Assert.That(actualTitle, Is.EqualTo(expectedTittle));


        }
        [Test]
        [TestCaseSource(typeof(DataSource), nameof(DataSource.InValidLoginTest))]
        public void InValidLoginTest(string username, string password, string expectedError)
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.EnterUsername(username);
            loginPage.EnterPassword(password);
            loginPage.ClickOnLogin();

            //Assert - Invalid username or password 
            string actualError = loginPage.GetInvalidErrorMessage();

            Assert.That(actualError, Is.EqualTo(expectedError));


        }
    }
}
