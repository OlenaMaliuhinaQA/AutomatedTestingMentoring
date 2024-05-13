namespace PageObjectTask.Tests
{
    public class ValidateArticleNamesFromCarrousel : BaseTest
    {
        [Test]
        public void ValidateArticleNamesFromCarrouselTest()
        {
            driver.FindElement(homePage.insightsTab).Click();
            driver.FindElement(insightsPage.rightArrowInCaurosel).Click();
            driver.FindElement(insightsPage.rightArrowInCaurosel).Click();
            string articleName = driver.FindElement(insightsPage.articleTitleFromCaurusel).Text.Trim();
            driver.FindElement(insightsPage.readMoreButton).Click();
            string articleName2 = driver.FindElement(articlePage.articleTitleFromArticlePage).Text.Trim();
            Assert.AreEqual(articleName, articleName2, "Article names do not match.");
        }               
    }
}
