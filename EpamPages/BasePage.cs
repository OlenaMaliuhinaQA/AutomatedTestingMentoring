using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

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
        public void ScrollToElement(IWebElement element)
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Perform();
        }
        public void WaitForFileDownload(string downloadDirectory, string fileName, TimeSpan timeout)
        {
            DateTime startTime = DateTime.Now;
            string filePath = Path.Combine(downloadDirectory, fileName);
            while (!File.Exists(filePath) && DateTime.Now - startTime < timeout)
            {
                Thread.Sleep(1000); // Sleep for 1 second
            }
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"File '{fileName}' not found in directory '{downloadDirectory}' after waiting for {timeout.TotalSeconds} seconds.");
            }
        }
    }
}