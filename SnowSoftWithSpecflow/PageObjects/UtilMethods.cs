using System;
using OpenQA.Selenium;
using NUnit.Framework;

namespace SnowSoftWithSpecflow.PageObjects
{
    public class UtilMethods
    {
        private readonly IWebDriver _driver;

        public UtilMethods(IWebDriver driver)
        {
            _driver = driver;
        }

        public void SetURL(String url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public void AssertTitle(String expectedTitle)
        {
            String actualTitle = _driver.Title;
            Assert.AreEqual(expectedTitle, actualTitle);
        }

        public void AssertEqual(String expValue, String actValue)
        {
            Assert.AreEqual(expValue, actValue);
        }
    
    }
}
