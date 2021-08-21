using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;


namespace SelinumCodeNETCore.Utilities
{
    public  class Libconfiguration: DriverControl
    {
        //ContentPlaceHolder1_AllMealsCombo
        public static void ComboBoxControl(string controlName,string value)
        {
            var comboControl = driver.FindElement(By.XPath($"//input[@id='{controlName}-awed']"));


            comboControl.Clear();
            comboControl.SendKeys(value);

            var optionSelect = driver.FindElement(By.XPath($"//div[@id='{controlName}-dropmenu']//li[text()='{value}']"));

            optionSelect.Click();


        }
    }
}
