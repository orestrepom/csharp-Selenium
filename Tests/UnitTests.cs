using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;

namespace sahiTest.Tests
{
    public class UnitTests : BasePage
    {

        [SetUp]
        public void BeforeEach()
        {
            driver = new ChromeDriver(Path.GetFullPath(@"../../../" + "_drivers"));
            driver.Url = "http://sahitest.com/demo/training/login.htm";
            Pages.Init();
            Pages.loginPage.username.SendKeys("test");
            Pages.loginPage.password.SendKeys("secret");
            Pages.loginPage.loginButton.Click();

        }

        [TearDown]
        public void AfterEach()
        {
            driver.Quit();
        }

         [Test]
        public void LoginSuccessTest()
        {
            var HomePageValidationText = Pages.homePage.HomePageValidationText.Text;
            Assert.AreEqual("All available books", HomePageValidationText);

        }

        [Test]
        public void AddValidItemstoCart()
        {
            //Pages.homePage.ClearButton.Clear();
            //int GrandTotal , ruby = 3, python = 5;

           // GrandTotal = (java * 300) + (ruby * 200) + (python * 350);
            Pages.homePage.JavaField.Clear();
            Pages.homePage.RubyField.Clear();
            Pages.homePage.PythonField.Clear();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(600);
            Pages.homePage.JavaField.SendKeys("1");
            Pages.homePage.RubyField.SendKeys("3");
            Pages.homePage.PythonField.SendKeys("5");
            Pages.homePage.AddButton.Click();


        }

    }
}
