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

        [When(@"URL ""(.*)"" is opened in ""(.*)"" browser")]
        public void WhenURLIsOpenedInBrowser(string url, string browserName)
        {
            driver = browserInit.LaunchBrowser(browserName, url);
        }
               
        [Then(@"Title should be ""(.*)""")]
        public void ThenTitleShouldBe(string browserTitle)
        {
            actualTitle = driver.Title;
            Assert.AreEqual(browserTitle, actualTitle);
            browserInit.CloseBrowser();
        }


    }
}
