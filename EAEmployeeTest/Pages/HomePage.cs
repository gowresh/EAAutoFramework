using EAAutoFramework.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAEmployeeTest.Pages
{
    class HomePage : BasePage
    {
         IWebElement lnkManagedContacts => _driver.FindElement(By.XPath("//div[text() ='Managed Contacts']"));

        public ManagedContactsPage ClickManagedContacts()
        {
           lnkManagedContacts.Click();
           return GetInstance<ManagedContactsPage>();
        }
    }
}
