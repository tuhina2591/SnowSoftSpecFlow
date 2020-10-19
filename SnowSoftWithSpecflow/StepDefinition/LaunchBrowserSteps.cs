using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SnowSoftWithSpecflow.PageObjects;
using TechTalk.SpecFlow;

namespace SnowSoftWithSpecflow.StepDefinition
{
    [Binding]
    public sealed class LaunchBrowserSteps
    {
        BrowserInit browserInit = new BrowserInit();
        IWebDriver driver;
        String actualTitle;

        [Given(@"I launch Snow Software URL with any browser")]
        public void GivenILaunchSnowSoftwareURLWithAnyBrowser()
        {
            driver = browserInit.LaunchBrowser("chrome", "http://www.snowsoftware.com");
        }

        [When(@"the page is opened")]
        public void WhenThePageIsOpened()
        {
            actualTitle = driver.Title;
        }

        [Then(@"the Snow Home Page should be opened")]
        public void ThenTheSnowHomePageShouldBeOpened()
        {
            Assert.AreEqual("Snow Software – The Technology Intelligence Platform", actualTitle);
        }

        [Then(@"the browser should be closed afterwards")]
        public void ThenTheBrowserShouldBeClosedAfterwards()
        {
            browserInit.CloseBrowser();
        }



    }
}
