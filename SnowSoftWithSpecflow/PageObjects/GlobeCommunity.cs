using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace SnowSoftWithSpecflow.PageObjects
{
    public class GlobeCommunity
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;
        private readonly By labelText = By.XPath("//h2[contains(text(),'Welcome to Snow Globe')]");
        private readonly By searchTextBox = By.XPath("//input[@placeholder='How can we help?']");
        private readonly By dropDown = By.CssSelector("[class='result-container']");
        private readonly By releaseLink = By.XPath("//div[contains(@class, 'result-container')]//span[contains(text(), 'Release Notes')]");

        public GlobeCommunity(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }

        public String GetLabelText()
        {
            _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(searchTextBox));
            String label = _driver.FindElement(labelText).Text;
            return label;
        }

        public void SetSearchString(String searchText)
        {
            _driver.FindElement(searchTextBox).SendKeys(searchText);
        }
    
        public void ClickReleaseLink()
        {
            _driver.FindElement(releaseLink).Click();
        }
    }
}
