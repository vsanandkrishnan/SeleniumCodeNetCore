using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using SelinumCodeNETCore.Utilities;

namespace SelinumCodeNETCore.Pages
{
    public class HomePage : DriverControl
    {

        IWebElement LnkLogin => driver.FindElement(By.LinkText("Login"));

        IWebElement LnklogOff => driver.FindElement(By.LinkText("Log off"));

        IWebElement EmployeeLink => driver.FindElement(By.LinkText("Employee List"));

        public LoginPage ClickLnkLogin()
        {
            LnkLogin.Click();
            return new LoginPage();
        }

        public bool IsLogOffExist() => LnklogOff.Displayed;

        public EmployeeListPage ClickEmployeeList()
        {
            EmployeeLink.Click();
            return new EmployeeListPage();
        }


    }
}
