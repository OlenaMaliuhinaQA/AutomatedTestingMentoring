namespace PageObjectTask.Tests
{
    public class ValidateArticleNamesFromCarrousel : BaseTest
    {
        [Test]
        public void ValidateArticleNamesFromCarrouselTest()
        {
            homePage.insightsTab.Click();
            insightsPage.rightArrowInCaurosel.Click();
            insightsPage.rightArrowInCaurosel.Click();
            string articleName = insightsPage.articleTitleFromCaurusel.Text.Trim();
            insightsPage.readMoreButton.Click();
            string articleName2 = articlePage.articleTitleFromArticlePage.Text.Trim();
            Assert.AreEqual(articleName, articleName2, "Article names do not match.");
        }
    }
}