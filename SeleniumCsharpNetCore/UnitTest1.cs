using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using SeleniumCsharpNetCore.Pages;

namespace SeleniumCsharpNetCore
{
    public class Tests : DriverHelpers
    {

        [SetUp]
        public void Setup()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            // chromeOptions.
            Console.WriteLine("setup");
            // Driver = new ChromeDriver(Environment.CurrentDirectory);
            Driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            // Driver.Navigate().GoToUrl("https://executeautomation.com");
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com");
            Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");
            Driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")).Click();

            // CustomControl control = new CustomControl();
            CustomControl.combobox("ContentPlaceHolder1_AllMealsCombo", "Almond");

            Console.WriteLine("Test1ContentPlaceHolder1_AllMealsCombo");
            Assert.Pass();
        }

        [Test]
        public void LoginTest()
        {
            Driver.Navigate().GoToUrl("http://eaapp.somee.com/");

            homePage hompge = new homePage();
            loginPage lgnpge = new loginPage();

            hompge.clicklogin();
            lgnpge.EnterUsernameandPassword("admin", "password");
            lgnpge.ClickLogin();
            Assert.That(hompge.islogOffExists(), Is.True, "Log off button not displayed");
        }
    }
}