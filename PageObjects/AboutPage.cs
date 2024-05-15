using OpenQA.Selenium;

namespace PageObjectTask.PageObjects
{
    public class AboutPage : BasePage
    {
        public By acceptCookiesButton = By.XPath("//button[@id='onetrust-accept-btn-handler']");
        public By EPAMAtGlanceSection = By.CssSelector("p.scaling-of-text-wrapper > span.museo-sans-light > span.font-size-80-33");
        public By downloadButton = By.CssSelector("a.button-ui-23.btn-focusable\r\n");
    }
}