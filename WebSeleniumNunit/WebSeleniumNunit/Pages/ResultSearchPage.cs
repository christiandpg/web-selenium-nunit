using System;
using System.Collections.Generic;
using System.Text;
using WebSeleniumNunit.Elements;

namespace WebSeleniumNunit.Pages
{
    class ResultSearchPage : ResultSearchPageElements
    {
        public string GetProductTitle()
        {
            return resultListTitles.Text;
        }

        public string GetProductPrice()
        {
            return resultListPriceSymbol.Text + resultListPrices.Text + "," + resultListPriceFraction.Text;
        }

        public void SelectProduct()
        {
            resultListTitles.Click();
        }

        public void GoToCart()
        {
            addCartButton.Click();
            cartButton.Click();
        }
    }
}
