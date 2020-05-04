using WebSeleniumNunit.Elements;

namespace WebSeleniumNunit.Pages
{
    class CartPage : CartPageElements
    {
        public string GetCartProductTitle()
        {
            return cartProductTitle.Text;
        }

        public string GetCartProductPrice()
        {
            return cartProductPrice.Text;
        }
    }
}
