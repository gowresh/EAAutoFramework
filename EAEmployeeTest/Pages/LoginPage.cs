﻿using System;
using System.Collections.Generic;
using EAAutoFramework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;

namespace EAEmployeeTest.Pages
{
    class LoginPage : BasePage
    {

  

        public LoginPage(RemoteWebDriver driver): base(driver)
        {
            
        }

        public IWebElement txtUserName => _driver.FindElement(By.XPath("//*[@placeholder='Username']"));
        public IWebElement txtPassword => _driver.FindElement(By.XPath("//*[@placeholder='Password']"));
        public IWebElement btnLogin => _driver.FindElement(By.XPath("//span[text()='Sign In']"));


    }
}