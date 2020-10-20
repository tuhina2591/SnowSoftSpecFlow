using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using SnowSoftWithSpecflow.PageObjects;
using System.Threading;
using SnowSoftWithSpecflow.PageObjectss;

namespace SnowSoftWithSpecflow.StepDefinition
{
    [Binding]
    public sealed class LicManagerArticleNumSteps
    {
        private readonly UtilMethods _utilMethods;
        private readonly SnowHome _snowHome;
        private readonly GlobeCommunity _globeCommunity;
        private readonly LicenseManager _licenseManager;
        public LicManagerArticleNumSteps(IWebDriver driver)
        {
            _utilMethods = new UtilMethods(driver);
            _snowHome = new SnowHome(driver);
            _globeCommunity = new GlobeCommunity(driver);
            _licenseManager = new LicenseManager(driver);
        }

        [Given(@"User is on ""(.*)""")]
        public void GivenUserIsOn(string url)
        {
            _utilMethods.SetURL(url); ;
        }

        [Given(@"Snow Globe Page using Success Link is open")]
        public void GivenSnowGlobePageUsingSuccessLinkIsOpen()
        {
            _snowHome.MoveToSuccessLink();
            _snowHome.ClickSnowGlobeLink();
            Thread.Sleep(10000);
        }

        [Given(@"""(.*)"" is entered in SearchBox")]
        public void GivenIsEnteredInSearchBox(string searchText)
        {
            _globeCommunity.SetSearchString(searchText);
            Thread.Sleep(10000);
        }

        [Given(@"""(.*)"" Link is Clicked")]
        public void GivenLinkIsClicked(string p0)
        {
            _globeCommunity.ClickReleaseLink();
            Thread.Sleep(30000);
        }

        [Then(@"the Article Number should be ""(.*)""")]
        public void ThenTheArticleNumberShouldBe(String articleNumber)
        {
            String number = _licenseManager.GetArticleNumber();
            _utilMethods.AssertEqual(articleNumber, number);
        }
    }
}
