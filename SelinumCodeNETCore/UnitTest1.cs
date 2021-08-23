using NUnit.Framework;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using SelinumCodeNETCore.Utilities;
using System.Collections.Generic;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using SelinumCodeNETCore.Pages;

namespace SelinumCodeNETCore
{
    public class Tests : DriverControl
    {
        [SetUp]
        public void Setup()
        {
    
            driver = new ChromeDriver(@"C:\Chrome");
        }

        [Test]
        public void LoginTest()
        {
            driver.Navigate().GoToUrl("http://eaapp.somee.com/");
            driver.Manage().Window.Maximize();

            var homePage = new HomePage();
            var loginPage = homePage.ClickLnkLogin();

            loginPage.EnterUserNameAndPassword("admin", "password");
            loginPage.ClickLogin();

            Assert.That(homePage.IsLogOffExist(), Is.True,"Log off link not displayed.");

            var employeeListPage=homePage.ClickEmployeeList();

            employeeListPage.ClickOnCreateNewLink();

        }

        [TearDown]
        public void TearDown()
        {
             driver.Close();
        }
    }
}