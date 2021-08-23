using OpenQA.Selenium;
using SelinumCodeNETCore.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SelinumCodeNETCore.Pages
{
    public class EmployeeCreate : DriverControl
    {
        IWebElement EmpNameTextBox => driver.FindElement(By.Id("Name"));

        IWebElement EmpSalaryTextBox => driver.FindElement(By.Id("Salary"));

        IWebElement EmpDurationWorked => driver.FindElement(By.Id("DurationWorked"));

        IWebElement EmpGrade => driver.FindElement(By.Id("Grade"));

        IWebElement EmpEmail => driver.FindElement(By.Id("Email"));

        IWebElement EmpCreateButton => driver.FindElement(By.XPath("//input[@value='Create']"));

        public void ClickOnEmpCreateButton() => EmpCreateButton.Click(); 

        public EmployeeListPage FillEmployeeDetails(string empName,string empSalary,string durationWorked, string empGrade,string empEmail)
        {
            EmpNameTextBox.SendKeys(empName);
            EmpSalaryTextBox.SendKeys(empSalary);
            EmpDurationWorked.SendKeys(durationWorked);
            EmpGrade.SendKeys(empGrade);
            EmpEmail.SendKeys(empEmail);
            ClickOnEmpCreateButton();

            return new EmployeeListPage();
        }
    }
}
