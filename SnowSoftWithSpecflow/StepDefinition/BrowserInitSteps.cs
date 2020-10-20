using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SnowSoftWithSpecflow.Factory;
using SnowSoftWithSpecflow.PageObjects;
using SnowSoftWithSpecflow.Support;
using TechTalk.SpecFlow;

namespace SnowSoftWithSpecflow.StepDefinition
{
    [Binding]
    public class BrowserInitSteps
    {

        private readonly BrowserInit _browserInit;
        String actualTitle;

        public BrowserInitSteps(IWebDriver driver)
        {
            _browserInit = new BrowserInit(driver);   
        }

        [Given(@"""(.*)"" broswer is Launched")]
        public void GivenBroswerIsLaunched(string bName)
        {
            _browserInit.SetBrowserName(bName);
        }

        [When(@"URL ""(.*)"" is accesed")]
        public void WhenURLIsAccesed(string url)
        {
            _browserInit.SetURL(url);
        }

        [Then(@"the Title should be ""(.*)""")]
        public void ThenTheTitleShouldBe(string browserTitle)
        {
            _browserInit.AssertTitle(browserTitle);
        }



    }
}
