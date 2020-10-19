using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using SnowSoftWithSpecflow.PageObjects;
using System.Threading;
using SnowSoftWithSpecflow.PageObjectss;

namespace SnowSoftWithSpecflow.StepDefinition
{
    [Binding]
    public sealed class ArticleNumValidationSteps
    {
        BrowserInit browserInit = new BrowserInit();
        SnowHome snowHome;
        GlobeCommunity globeCommunity;
        LicenseManager licenseManager;
        IWebDriver driver;

        //private readonly ScenarioContext _scenarioContext;

        //public ArticleNumValidationSteps(ScenarioContext scenarioContext)
        //{
        //    _scenarioContext = scenarioContext;
        //}
        [Given(@"User is on ""(.*)"" Page in ""(.*)""")]
        public void GivenUserIsOnPageIn(string searchText, string browserName)
        {
            driver = browserInit.LaunchBrowser(browserName, "http://www.snowsoftware.com");
            snowHome = new SnowHome(driver);
            globeCommunity = new GlobeCommunity(driver);
            snowHome.MoveToSuccessLink();
            snowHome.ClickSnowGlobeLink();
            Thread.Sleep(10000);
            globeCommunity.SetSearchString(searchText);
            Thread.Sleep(10000);
            globeCommunity.ClickReleaseLink();
        }

        [Then(@"Article Number should be ""(.*)""")]
        public void ThenArticleNumberShouldBe(String articleNumber)
        {
            Thread.Sleep(10000);
            licenseManager = new LicenseManager(driver);
            String number = licenseManager.GetArticleNumber();
            Assert.AreEqual(articleNumber,number);
            browserInit.CloseBrowser();
        }

    }
}
