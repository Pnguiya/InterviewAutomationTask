using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Amazon.TestAutomation.Task.Pages
{
    public class SearchPage
    {
        private IWebDriver _driver;


        public SearchPage(IWebDriver driver)
        {
            _driver = driver;
        }


        public void Searchfield(string search)
        {
            IWebElement searchLocator = _driver.FindElement(searchfield);
            searchLocator.Clear();
            searchLocator.SendKeys(search);
        }

        public void AcceptPageCookies()
        {
            _driver.FindElement(acceptCookies).Click();
        }

        public void ClicksOnSearchButton()
        {
            _driver.FindElement(searchButton).Click();
        }
        public void ClickSmartWatch()
        {
            var elements = _driver.FindElements(smartWatch);
            Actions action = new Actions(_driver);
              if (elements.Count > 0)
               {
                 action.MoveToElement(elements[2]).Perform();
                 elements[3].Click();
               }
        }

        public void AddToBasketButton()
        {
            var basketElements = _driver.FindElements(addToBasketButton);
            basketElements[0].Click();

            if (IsElementPresent())
            {
                var elements = _driver.FindElements(protectionLocator);
                elements[0].Click();
            }
            
        }

        

        public string VerifyBasket()
        {
            return _driver.FindElement(verifyBasket).Text.Trim();
        }



        private bool IsElementPresent()
        {
            try
            {
                _driver.FindElement(protectionLocator);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }









        private By searchfield = By.CssSelector("[aria-label='Search Amazon.co.uk']");
        private By searchButton = By.Id("nav-search-submit-button");
        private By smartWatch = By.CssSelector("[class='a-size-medium a-color-base a-text-normal']");
        private By addToBasketButton = By.Id("add-to-cart-button");
        private By verifyBasket = By.CssSelector("[data-cel-widget=NATC_SMART_WAGON_CONF_MSG_SUCCESS]");
        private By acceptCookies = By.Id("sp-cc-accept");
        private By protectionLocator = By.CssSelector("[class='a-button a-button-span12 a-button-base']");
    }
}
