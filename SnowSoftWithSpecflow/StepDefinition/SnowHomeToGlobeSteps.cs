using System;
using OpenQA.Selenium;
using SnowSoftWithSpecflow.PageObjects;
using TechTalk.SpecFlow;

namespace SnowSoftWithSpecflow.StepDefinition
{
    [Binding]
    public class SnowHomeToGlobeSteps
    {
        private readonly UtilMethods _utilMethods;
        private readonly SnowHome _snowHome;
        private readonly GlobeCommunity _globeCommunity;

        public SnowHomeToGlobeSteps(IWebDriver driver)
        {
            _utilMethods = new UtilMethods(driver);
            _snowHome = new SnowHome(driver);
            _globeCommunity = new GlobeCommunity(driver);
        }

        [Given(@"SnowSoft URL ""(.*)"" is accessed")]
        public void GivenSnowSoftURLIsAccessed(string url)
        {
            _utilMethods.SetURL(url);
            Console.WriteLine("Snow Software Page is Open");
        }

        [When(@"User Hover on Success Tab")]
        public void WhenUserHoverOnSuccessTab()
        {
            _snowHome.MoveToSuccessLink();
        }

        [When(@"Clicks on Snow Globe Community Link")]
        public void WhenClicksOnSnowGlobeCommunityLink()
        {
            _snowHome.ClickSnowGlobeLink();
            _utilMethods.Sleep(10000);
        }

        [Then(@"""(.*)"" Page should be opened")]
        public void ThenPageShouldBeOpened(string pageName)
        {
            String pageLabel = _globeCommunity.GetLabelText();
            _utilMethods.AssertEqual(pageName,pageLabel);
        }

    }
}

