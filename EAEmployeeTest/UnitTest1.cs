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
      
        public void OpenBrowser(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.InternetExplorer:
                        break;
                case BrowserType.FireFox:
                    break;
                case BrowserType.Chrome:
                    DriverContext.Driver = new ChromeDriver(@"C:\Users\gnagesh\Downloads\chromedriver_win32");
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    DriverContext.Driver.Manage().Window.Maximize();
                    DriverContext.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
                    break;
                    
            }
        }

        [TestMethod]
        public void TestMethod1()
        {
            
            OpenBrowser(BrowserType.Chrome);
            DriverContext.Browser.GotoUrl(url);

            //LoginPage
            CurrentPage = GetInstance<LoginPage>();
                
            //HomePage
            CurrentPage = CurrentPage.As<LoginPage>().Login("val1", "qwer1234");

            //ManagedContactsPage
            CurrentPage = CurrentPage.As<HomePage>().ClickManagedContacts();
            
        }

   
    }
}
