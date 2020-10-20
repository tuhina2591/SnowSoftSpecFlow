using System;
using SnowSoftWithSpecflow.PageObjects;
using SnowSoftWithSpecflow.Factory;
using SnowSoftWithSpecflow.Support;
using System.Text;
using OpenQA.Selenium;
using NUnit.Framework;

namespace SnowSoftWithSpecflow.PageObjects
{
    public class UtilMethods
    {
        private readonly IWebDriver _driver;
        private String _value;
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
