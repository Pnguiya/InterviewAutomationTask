using Amazon.TestAutomation.Task.Pages;
using Amazon.TestAutomation.Task.SetUp;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace Amazon.TestAutomation.Task.StepDefinitions
{
    [Binding]
    public class SearchStepDefinitions
    {
        private Context _context;
        private SearchPage _searchpage;
        IWebDriver _driver;

        public SearchStepDefinitions(Context context, SearchPage searchpage, IWebDriver driver)
        {
            _context = context;
            _searchpage = searchpage;
            _driver = driver;
        }

        [Given(@"that the amazon website is loaded on Chrome")]
        public void GivenThatTheAmazonWebsiteIsLoadedOnChrome()
        {
            _context.LoadApplicationUnderTest();
            _searchpage.AcceptPageCookies();
        }

        [When(@"a user fills in the search field with (.*)")]
        public void WhenAUserFillsInTheSearchField(string searchData)
        {
            _searchpage.Searchfield(searchData);
        }

        [When(@"a user clicks on search button")]
        public void WhenAUserClicksOnSearchButton()
        {
            _searchpage.ClicksOnSearchButton();
        }

        [When(@"a user clicks on a camera lens")]
        [When(@"a user clicks on a smart watch")]
        [When(@"a user clicks on a laptop")]
        public void WhenAUserClicksOnASmartWatch()
        {
            Thread.Sleep(650);
            _searchpage.ClickSmartWatch();
        }

        [When(@"the user clicks on add to basket button")]
        public void WhenTheUserClicksOnAddToBasketButton()
        {

            Thread.Sleep(650);
            _searchpage.AddToBasketButton();
        }

        [Then(@"the item should display (.*)")]
        public void ThenTheItemShouldDisplay(string expectedResult)
        {
            Assert.AreEqual(_searchpage.VerifyBasket(), expectedResult);
        }


       






        [AfterScenario]
        public void CloseApplicationUnderTest()
        {
            _context.ShutDownApplicationUnderTest();
        }
    }
}
