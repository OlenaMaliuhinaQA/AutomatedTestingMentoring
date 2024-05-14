using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PageObjectTask.PageObjects
{
    public class AboutPage : BasePage
    {
        private IWebDriver driver;
        public AboutPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }
        public IWebElement acceptCookiesButton => driver.FindElement(By.XPath("//button[@id='onetrust-accept-btn-handler']"));

        public IWebElement EPAMAtGlanceSection => driver.FindElement(By.CssSelector("p.scaling-of-text-wrapper > span.museo-sans-light > span.font-size-80-33"));

        public IWebElement downloadButton => driver.FindElement(By.CssSelector("a.button-ui-23.btn-focusable\r\n"));

        //public By acceptCookiesButton = By.XPath("//button[@id='onetrust-accept-btn-handler']");
        //public By EPAMAtGlanceSection = By.CssSelector("p.scaling-of-text-wrapper > span.museo-sans-light > span.font-size-80-33");
        //public By downloadButton = By.CssSelector("a.button-ui-23.btn-focusable\r\n");
        
    }
}
