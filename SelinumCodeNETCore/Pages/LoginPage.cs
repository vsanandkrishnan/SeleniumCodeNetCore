using OpenQA.Selenium;
using SelinumCodeNETCore.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SelinumCodeNETCore.Pages
{
    public class LoginPage : DriverControl
    {

        //Login page Username
        IWebElement textUserName => driver.FindElement(By.Id("UserName"));

        //Login Page Password
        IWebElement textPassword => driver.FindElement(By.Id("Password"));

        //Login button
        IWebElement loginButton => driver.FindElement(By.XPath("//input[@value='Log in']"));


        public void EnterUserNameAndPassword(string userName,string password)
        {
            textUserName.SendKeys("admin");
            textPassword.SendKeys("password");
        }

        public void ClickLogin() => loginButton.Click();
     
    }
}
