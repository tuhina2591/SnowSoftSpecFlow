using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using SnowSoftWithSpecflow.PageObjects;
using SnowSoftWithSpecflow.StepDefinition;
using TechTalk.SpecFlow;

namespace SnowSoftWithSpecflow.StepDefinition
{
    [Binding]
    public sealed class SnowGlobeRedirectionSteps
    {
        BrowserInit browserInit;
        SnowHome snowHome;
        GlobeCommunity globeCommunity;
        IWebDriver driver;
       

        [Given(@"My Browser is Open with Snow Software URL")]
        public void GivenMyBrowserIsOpenWithSnowSoftwareURL()
        {
            driver = browserInit.LaunchBrowser("chrome", "http://www.snowsoftware.com");
        }

        [When(@"I Hover on Success Tab")]
        public void WhenIHoverOnSuccessTab()
        {
            snowHome = new SnowHome(driver);
            globeCommunity = new GlobeCommunity(driver);
            snowHome.MoveToSuccessLink();
        }

        [When(@"Click on Snow Globe Community Link")]
        public void WhenClickOnSnowGlobeCommunityLink()
        {
            snowHome.ClickSnowGlobeLink();
            Thread.Sleep(10000);

        }
        [Then(@"the Welcome to Snow Globe Page should be opened")]
        public void ThenTheWelcomeToSnowGlobePageShouldBeOpened()
        {
            String pageLabel = globeCommunity.GetLabelText();
            Assert.AreEqual("Welcome to Snow Globe", pageLabel);
        }

    }
}

