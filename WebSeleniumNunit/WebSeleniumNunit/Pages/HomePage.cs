using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using WebSeleniumNunit.Elements;

namespace WebSeleniumNunit.Pages
{
    class HomePage : HomePageElements
    {
        public void PerformSearch(string product)
        {
            sarchField.SendKeys(product);
            sarchField.SendKeys(Keys.Enter);
        }
    }
}
