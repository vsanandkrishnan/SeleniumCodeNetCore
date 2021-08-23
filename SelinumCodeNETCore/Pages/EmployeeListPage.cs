using OpenQA.Selenium;
using SelinumCodeNETCore.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SelinumCodeNETCore.Pages
{
    public class EmployeeListPage : DriverControl
    {
        IWebElement createNewLink => driver.FindElement(By.LinkText("Create New"));

        public void ClickOnCreateNewLink() => createNewLink.Click();

    }
}
