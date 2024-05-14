using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectTask.PageObjects
{
    public class ArticlePage : BasePage
    {
        private IWebDriver driver;
        public ArticlePage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }
        public IWebElement articleTitleFromArticlePage => driver.FindElement(By.XPath("//span[contains(@class, 'font-size-80-33')]/span[contains(@class, 'museo-sans-light')][text()='From Taming Cloud Complexity to Achieving Cloud Mastery']"));

    }
 }
