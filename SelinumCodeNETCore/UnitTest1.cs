using NUnit.Framework;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using SelinumCodeNETCore.Utilities;
using System.Collections.Generic;
using OpenQA.Selenium.Support.UI;
using System.Threading;

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
        public void CheckTheTest()
        {
            driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.FindElement(By.CssSelector("#ContentPlaceHolder1_Meal")).SendKeys("Tomato");
            driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")).Click();      

            Libconfiguration.ComboBoxControl("ContentPlaceHolder1_AllMealsCombo", "Carrot");

        }

        private void SeleniumExtras(IWebDriver arg)
        {
            throw new NotImplementedException();
        }

        [TearDown]
        public void TearDown()
        {
             driver.Close();
             driver.Quit();
        }
    }
}