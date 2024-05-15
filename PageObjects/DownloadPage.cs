using OpenQA.Selenium;

namespace PageObjectTask.PageObjects
{
    public class DownloadPage
    {
        private IWebDriver driver;
        public DownloadPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void WaitForFileDownload(string downloadDirectory, string fileName, TimeSpan timeout)
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
    }
}