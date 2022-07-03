using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCsharpNetCore.Pages
{
    class homePage : DriverHelpers
    {
        IWebElement lnklogin => Driver.FindElement(By.LinkText("Login"));
        IWebElement lnklogoff => Driver.FindElement(By.LinkText("Logoff"));
        public void clicklogin() => lnklogin.Click();

        public bool islogOffExists() => lnklogoff.Displayed;
    }
}
