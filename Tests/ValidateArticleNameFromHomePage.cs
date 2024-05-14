using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System.Xml.Linq;
using System.Xml.XPath;

namespace PageObjectTask.Tests
{
    public class ValidateArticleNameFromHomePage : BaseTest
    {
        [Test]
        [TestCase("BLOCKCHAIN/Cloud/Automation")]
        public void ValidateArticleNameFromHomePageTest(string searchItem)
        {
           homePage.magnifierIcon.Click();
            IWebElement inputElement = homePage.searchInput;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            wait.Until(d => inputElement.Displayed);
            inputElement.Clear();
            inputElement.SendKeys(searchItem);
            homePage.findButton.Click();
            string htmlContent = "<div class=\"search-results__items\">...</div>";
            XElement root = XElement.Parse(htmlContent);
            bool allContainWords = root.XPathSelectElements("//article")
                .All(article =>
                    article.Value.Contains("BLOCKCHAIN", StringComparison.OrdinalIgnoreCase) ||
                    article.Value.Contains("Cloud", StringComparison.OrdinalIgnoreCase) ||
                    article.Value.Contains("Automation", StringComparison.OrdinalIgnoreCase));

            if (allContainWords)
            {
                Assert.Pass("All <article> elements contain the specified words.");
            }
            else
            {
                Assert.Fail("Not all <article> elements contain the specified words.");
            }
        }
    }
}