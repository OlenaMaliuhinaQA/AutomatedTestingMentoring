using PageObjectTask.PageObjects;

namespace PageObjectTask.Tests
{
    public class ValidateArticleNamesMatches : BaseTest
    {
        [Test]
        public void ValidateArticleNames()
        {
            BasePage basePage = new BasePage(); // creating an instance of the base page
            ArticlePage articlePage = new ArticlePage();
            InsightsPage insightsPage = new InsightsPage();

            driver.FindElement(basePage.insightsTab).Click(); // click on Insights tab

            //Swipe a carousel twice
            driver.FindElement(insightsPage.rightArrowInCaurosel).Click();
            driver.FindElement(insightsPage.rightArrowInCaurosel).Click();

            // Get the article name from Caurusel on InsightsPage
            string articleName = driver.FindElement(insightsPage.articleTitleFromCaurusel).Text.Trim();

            //Click on the “Read More” button.
            driver.FindElement(insightsPage.readMoreButton).Click();

            // Get the article name from  ArticlePage
            string articleName2 = driver.FindElement(articlePage.articleTitleFromArticlePage).Text.Trim();

            // Compare article names
            Assert.AreEqual(articleName, articleName2, "Article names do not match.");
        }
    }
}
