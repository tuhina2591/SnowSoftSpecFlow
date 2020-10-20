using System;
using OpenQA.Selenium;
using SnowSoftWithSpecflow.PageObjects;
using TechTalk.SpecFlow;

namespace SnowSoftWithSpecflow.StepDefinition
{
    [Binding]
    public class BrowserInitSteps
    {
        //private readonly BrowserInit _browserInit;
        private readonly UtilMethods _utilMethods;
       
        public BrowserInitSteps(IWebDriver driver)
        {
            //_browserInit = new BrowserInit(driver);
            _utilMethods = new UtilMethods(driver);
        }

        [Given(@"Broswer is Launched")]
        public void GivenBroswerIsLaunched()
        {
            Console.WriteLine("Snow Software Page is Open");
        }

        [When(@"URL ""(.*)"" is accesed")]
        public void WhenURLIsAccesed(string url)
        {
            _utilMethods.SetURL(url);
        }

        [Then(@"the Title should be ""(.*)""")]
        public void ThenTheTitleShouldBe(string browserTitle)
        {
            _utilMethods.AssertTitle(browserTitle);
        }



    }
}
