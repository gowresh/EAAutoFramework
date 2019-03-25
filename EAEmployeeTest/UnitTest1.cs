using System;
using EAAutoFramework.Base;
using EAEmployeeTest.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;

namespace EAEmployeeTest
{
    [TestClass]
    public class UnitTest1
    {
        string url = "http://10.183.139.76:81/40";
      

        [TestMethod]
        public void TestMethod1()
        {
            DriverContext.Driver = new ChromeDriver(@"C:\Users\gnagesh\Downloads\chromedriver_win32");
            DriverContext.Driver.Manage().Window.Maximize();
            DriverContext.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            DriverContext.Driver.Navigate().GoToUrl(url);
            Login();

        }

        public void Login()
        {
            LoginPage Loginpage = new LoginPage();
            Loginpage.txtUserName.SendKeys("val1");
            Loginpage.txtPassword.SendKeys("qwer1234");
            Loginpage.btnLogin.Click();
        }
    }
}
