using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace EAAutoFramework.Base
{
    public class Browser
    {
        private readonly IWebDriver _driver;

        public BrowserType Type { get; set; }

        public Browser(IWebDriver driver)
        {
            _driver = driver;
        }

        public void GotoUrl(string url)
        {
            DriverContext.Driver.Url = url;
        }
    }

    public enum BrowserType
    {
        InternetExplorer,
        FireFox,
        Chrome
    }
}
