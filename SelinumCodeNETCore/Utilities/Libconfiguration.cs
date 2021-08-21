using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using System.Threading;


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

        public static List<String> DisplayAllElementsInComboBoxDropdown(string controlName)
        {
            var comboControl = driver.FindElement(By.XPath($"//input[@id='{controlName}-awed']"));
            comboControl.Clear();

            var comboButton = driver.FindElement(By.XPath("//button[@class='o-cbxbtn o-ddbtn awe-btn o-btn']"));
            comboButton.Click();

            Thread.Sleep(1000);

            var comboBoxDropDown = driver.FindElements(By.XPath($"//div[@id='{controlName}-dropmenu']//li"));
            var dropDownMenu = new List<string>();
            foreach(var element in comboBoxDropDown)
            {
                dropDownMenu.Add(element.Text);
            }
            return dropDownMenu;           
        }
    }
}
