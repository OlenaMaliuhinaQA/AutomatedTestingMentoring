namespace PageObjectTask.Tests
{
    public class ValidateDownloadFile : BaseTest
    {
        [Test]
        public void ValidateDownloadFileTest()
        {
            string downloadDirectory = @"C:\Users\Olena_Maliuhina\Downloads";
            string filePath = Path.Combine(downloadDirectory, "EPAM_Corporate_Overview_Q4_EOY.pdf");

            homePage.aboutTab.Click();
            aboutPage.ScrollToElement(aboutPage.EPAMAtGlanceSection);
            aboutPage.downloadButton.Click();
            aboutPage.WaitForFileDownload(
                downloadDirectory,
                "EPAM_Corporate_Overview_Q4_EOY.pdf",
                TimeSpan.FromSeconds(30)
            );
            Assert.IsTrue(File.Exists(filePath), "File was not downloaded successfully.");
        }
    }
}
