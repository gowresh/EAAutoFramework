
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;

namespace EAAutoFramework.Base
{
    public abstract class BasePage
    {
        public RemoteWebDriver _driver;
        public BasePage(RemoteWebDriver driver)
        {

            _driver = driver;
        }

    }
}
