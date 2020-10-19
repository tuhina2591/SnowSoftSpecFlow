﻿using System;
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
    public sealed class LicenseManagerRedirectionSteps
    {
        BrowserInit browserInit = new BrowserInit();
        SnowHome snowHome;
        GlobeCommunity globeCommunity;
        IWebDriver driver;
        //private readonly ScenarioContext _scenarioContext;

        //public LicenseManagerRedirectionSteps(ScenarioContext scenarioContext)
        //{
        //    _scenarioContext = scenarioContext;
        //}
        [Given(@"Welcome to Snow Globe is open in the ""(.*)""")]
        public void GivenWelcomeToSnowGlobeIsOpenInThe(string browserName)
        {
            driver = browserInit.LaunchBrowser(browserName, "http://www.snowsoftware.com");
            snowHome = new SnowHome(driver);
            snowHome.MoveToSuccessLink();
            snowHome.ClickSnowGlobeLink();
            Thread.Sleep(10000);
        }

        [When(@"I enter ""(.*)""")]
        public void WhenIEnter(string searchText)
        {
            globeCommunity = new GlobeCommunity(driver);
            globeCommunity.SetSearchString(searchText);
            Thread.Sleep(10000);
                      
        }

        [When(@"click on ""(.*)"" link")]
        public void WhenClickOnLink(string p0)
        {
            globeCommunity.ClickReleaseLink();
            Thread.Sleep(30000);
            Console.WriteLine("Page" + p0 + "is Open");
        }

        [Then(@"I should be navigated to ""(.*)"" Page")]
        public void ThenIShouldBeNavigatedToPage(string pageName)
        {
            Assert.AreEqual(pageName, driver.Title);
            browserInit.CloseBrowser();
        }

    }
}
