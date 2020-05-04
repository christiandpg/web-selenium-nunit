using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using WebSeleniumNunit.Pages;


namespace WebSeleniumNunit.Tests
{
    class AmazonTests
    {
        public static IWebDriver Driver;

        [SetUp]
        public void startBrowser()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--disable-extensions");
            options.AddArgument("--no-sandbox");
            Driver = new ChromeDriver("C:\\", options);
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Driver.Url = "https://www.amazon.com.br/";
        }    

        [Test]
        public void AmazonTest()
        {
            var homePage = new HomePage();
            homePage.PerformSearch("Amazon echo");

            var resultSearchPage = new ResultSearchPage();
            string title = resultSearchPage.GetProductTitle();
            string price = resultSearchPage.GetProductPrice();
            resultSearchPage.SelectProduct();
            resultSearchPage.GoToCart();

            var cartPage = new CartPage();
            Assert.AreEqual(title, cartPage.GetCartProductTitle());
            Assert.AreEqual(price, cartPage.GetCartProductPrice());
        }

        [TearDown]
        public void closeBrowser()
        {
            Driver.Close();
        }
    }
}
