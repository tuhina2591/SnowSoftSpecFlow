﻿using System;
using OpenQA.Selenium;
using SnowSoftWithSpecflow.PageObjects;
using TechTalk.SpecFlow;

namespace SnowSoftWithSpecflow.StepDefinition
{
    [Binding]
    public class GlobeToLicManagerSteps
    {
        private readonly UtilMethods _utilMethods;
        private readonly SnowHome _snowHome;
        private readonly GlobeCommunity _globeCommunity;
        public GlobeToLicManagerSteps(IWebDriver driver)
        {
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
            _utilMethods.Sleep(10000);
        }

        [When(@"he enters ""(.*)"" in SearchBox")]
        public void WhenHeEntersInSearchBox(string searchText)
        {
            _globeCommunity.SetSearchString(searchText);
            _utilMethods.Sleep(10000);
        }

        [When(@"clicks on ""(.*)"" link")]
        public void WhenClicksOnLink(string p0)
        {
            _globeCommunity.ClickReleaseLink();
            _utilMethods.Sleep(20000);
            Console.WriteLine("Page" + p0 + "is Open");
        }

        [Then(@"he should be navigated to ""(.*)"" Page")]
        public void ThenHeShouldBeNavigatedToPage(string pageName)
        {
            _utilMethods.AssertTitle(pageName);
        }

    }
}
