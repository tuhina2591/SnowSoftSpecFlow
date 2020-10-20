using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace SnowSoftWithSpecflow.PageObjectss
{
    public class LicenseManager
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        private readonly By articleBlock = By.XPath("//div[contains(@class,'slds-page-header')]//span[contains(text(),'Article Number')]");
        private readonly By articleNumber = By.XPath("//div[contains(@class,'slds-page-header')]//span[contains(text(),'Article Number')]/..//span[@class='uiOutputText']");
        public LicenseManager(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }
    
        public String GetArticleNumber()
        {
            _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.VisibilityOfAllElementsLocatedBy(articleBlock));
            _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.VisibilityOfAllElementsLocatedBy(articleNumber));
            String articleNum = _driver.FindElement(articleNumber).Text;
            return articleNum;
        }
    
    
    
    }
}
