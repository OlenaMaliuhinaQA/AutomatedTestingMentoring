using OpenQA.Selenium;

namespace PageObjectTask.PageObjects
{
    public class InsightsPage : BasePage
    {
        private IWebDriver driver;
        public InsightsPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }
        public IWebElement keywordInput => driver.FindElement(By.XPath("//*[@id='new_form_job_search-keyword']"));

        public IWebElement rightArrowInCaurosel => driver.FindElement(By.CssSelector("button.slider__right-arrow.slider-navigation-arrow"));

        public IWebElement articleTitleFromCaurusel => driver.FindElement(By.CssSelector("span.font-size-60 span.museo-sans-light"));

        public IWebElement readMoreButton => driver.FindElement(By.CssSelector("a.custom-link.link-with-bottom-arrow.color-link.body-text.font-900.slider-cta-link"));
    }
}