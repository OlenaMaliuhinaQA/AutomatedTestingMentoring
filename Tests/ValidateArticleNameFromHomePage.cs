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
            wait.Until(d => homePage.searchInput.Displayed);
            homePage.searchInput.Clear();
            homePage.searchInput.SendKeys(searchItem);
            homePage.findButton.Click();
            bool allContainWords = homePage.homePageContent.XPathSelectElements("//article")
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