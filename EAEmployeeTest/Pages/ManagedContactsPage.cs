using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EAAutoFramework.Base;
using OpenQA.Selenium;

namespace EAEmployeeTest.Pages
{
    class ManagedContactsPage : BasePage
    {
        public IWebElement lnkG => _driver.FindElement(By.XPath("//a[1][text() ='G']"));  

        public void ClickGLink()
        {
            lnkG.Click();
        }
    }
}
