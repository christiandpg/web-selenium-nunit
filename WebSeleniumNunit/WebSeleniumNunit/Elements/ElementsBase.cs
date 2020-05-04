using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using WebSeleniumNunit.Tests;

namespace WebSeleniumNunit.Elements
{
    public abstract class ElementsBase
    {
        public IWebDriver Driver
        {
            get
            {
                return AmazonTests.Driver;
            }
        }
    }
}
