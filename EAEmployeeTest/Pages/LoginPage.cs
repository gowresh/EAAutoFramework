using System;
using System.Collections.Generic;
using EAAutoFramework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;

namespace EAEmployeeTest.Pages
{
    class LoginPage : BasePage
    {
         IWebElement txtUserName => _driver.FindElement(By.XPath("//*[@placeholder='Username']"));
         IWebElement txtPassword => _driver.FindElement(By.XPath("//*[@placeholder='Password']"));
         IWebElement btnLogin => _driver.FindElement(By.XPath("//span[text()='Sign In']"));

        public HomePage Login(string userName, string password)
        {
           
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
            btnLogin.Click();
            return GetInstance<HomePage>();
        }

    }
}