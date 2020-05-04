using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebSeleniumNunit.Elements
{
    class HomePageElements : ElementsBase
    {
        public IWebElement sarchField
        {
            get
            {
                return Driver.FindElement(By.Id("twotabsearchtextbox"));
            }
        }
        
    }
}
