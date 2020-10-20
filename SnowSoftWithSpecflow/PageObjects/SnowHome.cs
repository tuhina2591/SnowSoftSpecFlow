using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;


namespace SnowSoftWithSpecflow.PageObjects
{
    public class SnowHome
    {
        IWebDriver _driver;
        private IWebElement _succLink;
        private readonly WebDriverWait _wait;
        Actions _actions;
        private readonly By _successLink = By.LinkText("Success");
        private readonly By _snowGlobeLink = By.LinkText("Snow Globe Community");
        
        public SnowHome(IWebDriver driver)
        {
            _driver = driver;
            _actions = new Actions(driver);
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }
        
        public void MoveToSuccessLink()
        {
            _succLink = _driver.FindElement(_successLink);
            _actions.MoveToElement(_succLink).Perform();
        }
    
        public void ClickSnowGlobeLink()
        {
            _driver.FindElement(_snowGlobeLink).Click();
            
        }

    }
}
