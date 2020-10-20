using OpenQA.Selenium;
using System;
using SnowSoftWithSpecflow.Factory;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace SnowSoftWithSpecflow.PageObjects
    {
        public class BrowserInit
        {
            IWebDriver _driver;
            private DriverFactory _driverFactory;
            public BrowserInit(IWebDriver driver)
            {

            _driver = driver;

            }
            public void SetBrowserName(String browserName)
            {
                _driverFactory.driverInit(browserName);

            }
            public void SetURL(String url)
            {
                _driver.Navigate().GoToUrl(url);
               
            }
            
            public void AssertTitle(String expectedTitle)
            {
                String actualTitle= _driver.Title;
                Assert.AreEqual(expectedTitle, expectedTitle);
            }

        }
            
}



    
