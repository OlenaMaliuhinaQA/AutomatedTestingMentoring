using log4net;
using OpenQA.Selenium;

namespace PageObjectTask.Tests
{
    public class ValidateTechnologyWithinCountry : BaseTest
    {
        [Test]
        [TestCase("Java", "All Cities in Spain")]
        public void ValidateTechnologyWithinCountryTest(string programmingLanguage, string location)
        {
            homePage.careerTab.Click();
            careerPage.keywordInput.SendKeys(programmingLanguage);
            careerPage.locationDropdown.Click();
            careerPage.DropdownOptionByCountryName(location).Click();
            careerPage.remoteCheckBox.Click();
            careerPage.findButton.Click();
            careerPage.lastElementInList.Click();

            var numberOfResults = careerPage.findAllSearchResultItems.Count;
            IWebElement lastSearchResultItem = careerPage.findAllSearchResultItems[numberOfResults - 1];
            lastSearchResultItem.FindElement(careerPage.viewAndApplyButton).Click();

            if (careerPage.vacancyContent.Text.Contains(programmingLanguage))
            {
                Assert.Pass("The vacancy content contains the programming language.");
            }
            else
            {
                Assert.Fail($"The vacancy content does not contain the programming language '{programmingLanguage}'.");
            }
        }
    }

    [TestFixture]
    public class NUnitTests : BaseTest
    {
        protected ILog Log
        {
            get { return LogManager.GetLogger(this.GetType()); }
        }

        [Test]
        public void Test1()
        {
            Log.Info("Hello World of Logging :) ...");
        }
    }
}