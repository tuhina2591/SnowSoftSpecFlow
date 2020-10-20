using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace SnowSoftWithSpecflow.Factory
{
   public  class DriverFactory
    {
        IWebDriver webDriver;
        public IWebDriver driverInit(String browser)
        {
                       
            if (browser.Equals("chrome", StringComparison.OrdinalIgnoreCase))
            {
                webDriver = new ChromeDriver();
            }

            else if (browser.Equals("firefox", StringComparison.OrdinalIgnoreCase))
            {
                webDriver = new FirefoxDriver();
            }

            else if (browser.Equals("IE", StringComparison.OrdinalIgnoreCase))
            {
                webDriver = new InternetExplorerDriver();
            }
            
            else
            {
                throw new ArgumentException($"Browser not yet implemented : {browser} ");
            }
            return webDriver;
        }

        public void CloseBrowser()
        {
            webDriver.Quit();
        }

    }
}
