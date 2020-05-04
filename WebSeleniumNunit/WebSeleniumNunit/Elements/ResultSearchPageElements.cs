using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebSeleniumNunit.Elements
{
    class ResultSearchPageElements : ElementsBase
    {
        public IWebElement resultListTitles
        {
            get
            {
                return Driver.FindElement(By.XPath("//*[@class='a-section a-spacing-none']/h2"));
            }
        }

        public IWebElement resultListPriceSymbol
        {
            get
            {
                return Driver.FindElement(By.XPath("//*[@class='a-price-symbol']"));
            }
        }

        public IWebElement resultListPrices
        {
            get
            {
                return Driver.FindElement(By.XPath("//*[@class='a-price-whole']"));
            }
        }

        public IWebElement resultListPriceFraction
        {
            get
            {
                return Driver.FindElement(By.XPath("//*[@class='a-price-fraction']"));
            }
        }

        public IWebElement addCartButton
        {
            get
            {
                return Driver.FindElement(By.Id("add-to-cart-button"));
            }
        }

        public IWebElement cartButton
        {
            get
            {
                return Driver.FindElement(By.Id("hlb-view-cart-announce"));
            }
        }
    }
}
