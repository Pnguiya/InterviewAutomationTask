using BoDi;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.TestAutomation.Task.SetUp
{
    public class Context
    {
        private IObjectContainer _objectContainer;
        private IWebDriver _driver;
        string baseUrl = EnvironmentData.baseUrl;

        public Context(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
            _driver = new ChromeDriver();
            _objectContainer.RegisterInstanceAs<IWebDriver>(_driver);
        }

        public void LoadApplicationUnderTest()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Navigate().GoToUrl(baseUrl);
            _driver.Manage().Window.Maximize();
        }

        public void ShutDownApplicationUnderTest()
        {
            _driver?.Quit();
        }

    }
}
