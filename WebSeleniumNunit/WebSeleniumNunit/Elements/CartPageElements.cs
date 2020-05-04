using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebSeleniumNunit.Elements
{
    class CartPageElements : ElementsBase
    {
        public IWebElement cartProductTitle
        {
            get
            {
                return Driver.FindElement(By.CssSelector(".sc-product-title"));
            }
        }

        public IWebElement cartProductPrice
        {
            get
            {
                return Driver.FindElement(By.CssSelector(".sc-price-sign.a-text-bold"));
            }
        }
    }
}
