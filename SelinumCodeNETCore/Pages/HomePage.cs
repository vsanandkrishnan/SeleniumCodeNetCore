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

        public void ClickLnkLogin() => LnkLogin.Click();

        public bool IsLogOffExist() => LnklogOff.Displayed;
    }
}
