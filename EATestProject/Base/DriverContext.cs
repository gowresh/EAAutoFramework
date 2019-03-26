using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;

namespace EAAutoFramework.Base
{
    public static class DriverContext
    {
        private static RemoteWebDriver _driver;

        public static RemoteWebDriver Driver
        {
            get
            {
                return _driver;
            }
            set
            {
                _driver = value;
            }
        }


        public static Browser Browser { get; set; }

    }
}
