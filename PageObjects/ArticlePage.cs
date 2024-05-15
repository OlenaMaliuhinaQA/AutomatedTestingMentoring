using OpenQA.Selenium;

namespace PageObjectTask.PageObjects
{
    public class ArticlePage : BasePage
    {
        public By articleTitleFromArticlePage = By.XPath("//span[contains(@class, 'font-size-80-33')]/span[contains(@class, 'museo-sans-light')][text()='From Taming Cloud Complexity to Achieving Cloud Mastery']");
    }
}