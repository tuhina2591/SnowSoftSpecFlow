using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using SnowSoftWithSpecflow.PageObjects;
using OpenQA.Selenium;
using SnowSoftWithSpecflow.Factory;

namespace SnowSoftWithSpecflow.Support
{
    [Binding]
    public class Hooks
    {
        private IWebDriver _driver;
        private DriverFactory _driverFactory;
        private String bName;

        [BeforeTestRun]
        public void BeforeTestRun()
        {
            _driverFactory = new DriverFactory();
        }
       
        [BeforeScenario]
        public void BeforeScenario()
        {
            _driver = _driverFactory.driverInit(bName);
            _driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driverFactory.CloseBrowser();

        }
    }
}
