using TechTalk.SpecFlow;
using OpenQA.Selenium;
using SnowSoftWithSpecflow.Factory;
using BoDi;

namespace SnowSoftWithSpecflow.Support
{
    [Binding]
    public class Hooks
    {
        private IWebDriver _driver;
        private static DriverFactory _driverFactory;
        private readonly IObjectContainer _objectContainer;

        public Hooks(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            _driverFactory = new DriverFactory();
        }
       
        [BeforeScenario]
        public void BeforeScenario()
        {
            _driver = _driverFactory.driverInit("Chrome");
            _driver.Manage().Window.Maximize();
            _objectContainer.RegisterInstanceAs(_driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driverFactory.CloseBrowser();
        }
    }
}
