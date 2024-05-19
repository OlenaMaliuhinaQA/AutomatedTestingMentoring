using OpenQA.Selenium;

namespace PageObjectTask.PageObjects
{
    public class AboutPage : BasePage
    {
        private IWebDriver driver;
        public AboutPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }
        public IWebElement EPAMAtGlanceSection => driver.FindElement(By.CssSelector("p.scaling-of-text-wrapper > span.museo-sans-light > span.font-size-80-33"));

        public IWebElement downloadButton => driver.FindElement(By.CssSelector("a.button-ui-23.btn-focusable\r\n"));

    }
}