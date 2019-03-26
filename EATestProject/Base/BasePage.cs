
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;

namespace EAAutoFramework.Base
{
    public abstract class BasePage : Base
    {
        public RemoteWebDriver _driver;
        public BasePage()
        {

            _driver = DriverContext.Driver;
        }

    }
}
