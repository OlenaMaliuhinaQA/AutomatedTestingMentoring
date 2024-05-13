using OpenQA.Selenium;

namespace PageObjectTask.PageObjects
{
    public class BasePage
    {
        private IWebDriver driver;
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public IWebElement acceptButton => driver.FindElement(By.Id("onetrust-accept-btn-handler"));
        public IWebElement careerTab => driver.FindElement(By.XPath("//a[text()='Careers']"));
        public IWebElement servicesTab => driver.FindElement(By.XPath("//a[text()='Services']"));
        public IWebElement insightsTab => driver.FindElement(By.XPath("//a[text()='Insights']"));
        public IWebElement aboutTab => driver.FindElement(By.XPath("//a[text()='About']"));
    }
}
