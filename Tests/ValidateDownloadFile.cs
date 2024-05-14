using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace PageObjectTask.Tests
{
    public class ValidateDownloadFile : BaseTest
    {
        [Test]
        public void ValidateDownloadFileTest()
        {
            homePage.aboutTab.Click();
            aboutPage.acceptCookiesButton.Click();
            IWebElement element = aboutPage.EPAMAtGlanceSection;
           // ScrollToElement(driver, element);
            aboutPage.downloadButton.Click();
            string downloadDirectory = @"C:\Users\Olena_Maliuhina\Downloads";
            WaitForFileDownload(downloadDirectory, "EPAM_Corporate_Overview_Q4_EOY.pdf", TimeSpan.FromSeconds(30));
            string filePath = Path.Combine(downloadDirectory, "EPAM_Corporate_Overview_Q4_EOY.pdf");
            Assert.IsTrue(File.Exists(filePath), "File was not downloaded successfully.");

        }
        private void WaitForFileDownload(string downloadDirectory, string fileName, TimeSpan timeout)
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
        private void ScrollToElement(IWebDriver driver, IWebElement element)
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Perform();
        }
    }
}





