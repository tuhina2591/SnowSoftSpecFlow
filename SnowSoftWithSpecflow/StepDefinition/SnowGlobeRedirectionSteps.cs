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
        BrowserInit browserInit = new BrowserInit();
        SnowHome snowHome;
        GlobeCommunity globeCommunity;
        IWebDriver driver;
       

        [Given(@"Snow Home page is open")]
        public void GivenSnowHomePageIsOpen()
        {
            Console.WriteLine(driver.Title);
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
       
        [Then(@"the ""(.*)"" Page should be opened")]
        public void ThenThePageShouldBeOpened(string pageName)
        {
            String pageLabel = globeCommunity.GetLabelText();
            Assert.AreEqual(pageName, pageLabel);
        }

    }
}

