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
    public class UnitTest1 : Base
    {
        string url = "http://10.183.139.76:81/40";
      

        [TestMethod]
        public void TestMethod1()
        {
            DriverContext.Driver = new ChromeDriver(@"C:\Users\gnagesh\Downloads\chromedriver_win32");
            DriverContext.Driver.Manage().Window.Maximize();
            DriverContext.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            DriverContext.Driver.Navigate().GoToUrl(url);

            //LoginPage loginPage = new LoginPage();
            //CurrentPage  = loginPage.Login("val1", "qwer1234");
            //CurrentPage = ((HomePage)CurrentPage).ClickManagedContacts();
            // ((ManagedContactsPage)CurrentPage).ClickGLink();

            //LoginPage
            CurrentPage = GetInstance<LoginPage>();
                
            //HomePage
            CurrentPage = CurrentPage.As<LoginPage>().Login("val1", "qwer1234");

            //ManagedContactsPage
            CurrentPage = CurrentPage.As<HomePage>().ClickManagedContacts();
            CurrentPage.As<ManagedContactsPage>().ClickGLink();
        }

   
    }
}
