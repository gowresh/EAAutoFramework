using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;

namespace EAAutoFramework.Base
{
    public class Base
    {
        public BasePage CurrentPage { get; set; }

        public RemoteWebDriver _driver;

        protected TPage GetInstance<TPage>() where TPage : BasePage, new()
        {
            TPage pageInstance = new TPage()
            {
                _driver = DriverContext.Driver
            };

            return pageInstance;
        }

        public TPage As<TPage>() where TPage : BasePage
        {
            return (TPage)this;
        }
    }
}
