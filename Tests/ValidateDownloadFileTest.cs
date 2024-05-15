using OpenQA.Selenium;
using PageObjectTask.PageObjects;
using OpenQA.Selenium.Interactions;

namespace PageObjectTask.Tests
{
    public class ValidateDownloadFileTest : BaseTest
    {

        [Test]
        public void TestValidateFileDownload()
        {
            BasePage basePage = new BasePage(); // creating an instance of the base page
            AboutPage aboutPage = new AboutPage();

            driver.FindElement(basePage.aboutTab).Click(); // click on About tab

            driver.FindElement(aboutPage.acceptCookiesButton).Click(); // click AcceptCookies button

            IWebElement element = driver.FindElement(aboutPage.EPAMAtGlanceSection);
            ScrollToElement(driver, element);


            //click on the download button
            driver.FindElement(aboutPage.downloadButton).Click();


            // Specify the download directory path
            string downloadDirectory = @"C:\Users\Olena_Maliuhina\Downloads";

            // Wait for the file to download
            WaitForFileDownload(downloadDirectory, "EPAM_Corporate_Overview_Q4_EOY.pdf", TimeSpan.FromSeconds(30));

            // Validate that the file has been downloaded
            string filePath = Path.Combine(downloadDirectory, "EPAM_Corporate_Overview_Q4_EOY.pdf");
            Assert.IsTrue(File.Exists(filePath), "File was not downloaded successfully.");


        }

        private void WaitForFileDownload(string downloadDirectory, string fileName, TimeSpan timeout)
        {
            DateTime startTime = DateTime.Now;
            string filePath = Path.Combine(downloadDirectory, fileName);

            while (!File.Exists(filePath) && DateTime.Now - startTime < timeout)
            {
                System.Threading.Thread.Sleep(1000); // Sleep for 1 second
            }

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"File '{fileName}' not found in directory '{downloadDirectory}' after waiting for {timeout.TotalSeconds} seconds.");
            }
        }
        private void ScrollToElement(IWebDriver driver, IWebElement element)
        {
            // Create an Actions object
            Actions actions = new Actions(driver);

            // Move to the element
            actions.MoveToElement(element);

            // Perform the action
            actions.Perform();
        }
    }
}