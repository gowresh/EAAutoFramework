using System;
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
        private RemoteWebDriver _driver;

        [TestMethod]
        public void TestMethod1()
        {
            _driver = new ChromeDriver(@"C:\Users\gnagesh\Downloads\chromedriver_win32");
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);           
            _driver.Navigate().GoToUrl(url);
            Login();

        }

        public void Login()
        {
            LoginPage Loginpage = new LoginPage(_driver);
            Loginpage.txtUserName.SendKeys("val1");
            Loginpage.txtPassword.SendKeys("qwer1234");
            Loginpage.btnLogin.Click();
        }
    }
}
