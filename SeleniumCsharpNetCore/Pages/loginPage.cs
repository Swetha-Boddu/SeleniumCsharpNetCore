using System;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCsharpNetCore.Pages
{
    public class loginPage :DriverHelpers
    {
        IWebElement txtUserName => Driver.FindElement(By.Name("UserName"));
        IWebElement txtPassword => Driver.FindElement(By.Name("Password"));
        IWebElement btnlonIn => Driver.FindElement(By.CssSelector(".btn-default"));

        public void EnterUsernameandPassword(string userName, string Password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(Password);
        }

        public void ClickLogin()
        {
            btnlonIn.Click();
        }
    }
}
