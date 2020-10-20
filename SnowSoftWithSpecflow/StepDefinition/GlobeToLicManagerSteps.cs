using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using SnowSoftWithSpecflow.PageObjects;
using TechTalk.SpecFlow;

namespace SnowSoftWithSpecflow.StepDefinition
{
    [Binding]
    public class GlobeToLicManagerSteps
    {
        //private readonly BrowserInit _browserInit;
        private readonly UtilMethods _utilMethods;
        private readonly SnowHome _snowHome;
        private readonly GlobeCommunity _globeCommunity;
        public GlobeToLicManagerSteps(IWebDriver driver)
        {
            //_browserInit = new BrowserInit(driver);
            _utilMethods = new UtilMethods(driver);
            _snowHome = new SnowHome(driver);
            _globeCommunity = new GlobeCommunity(driver);
        }

        [Given(@"URL ""(.*)"" is accessed")]
        public void GivenURLIsAccessed(string url)
        {
            _utilMethods.SetURL(url);
        }

        [Given(@"the Snow Globe Page via Success Link is open")]
        public void GivenTheSnowGlobePageViaSuccessLinkIsOpen()
        {
            _snowHome.MoveToSuccessLink();
            _snowHome.ClickSnowGlobeLink();
            Thread.Sleep(10000);
        }

        [When(@"he enters ""(.*)"" in SearchBox")]
        public void WhenHeEntersInSearchBox(string searchText)
        {
            _globeCommunity.SetSearchString(searchText);
            Thread.Sleep(10000);
        }

        [When(@"clicks on ""(.*)"" link")]
        public void WhenClicksOnLink(string p0)
        {
            _globeCommunity.ClickReleaseLink();
            Thread.Sleep(30000);
            Console.WriteLine("Page" + p0 + "is Open");
        }

        [Then(@"he should be navigated to ""(.*)"" Page")]
        public void ThenHeShouldBeNavigatedToPage(string pageName)
        {
            _utilMethods.AssertTitle(pageName);
        }

    }
}
