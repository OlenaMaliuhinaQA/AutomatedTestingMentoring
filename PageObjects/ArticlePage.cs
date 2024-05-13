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
        public By articleTitleFromArticlePage = By.XPath("//span[contains(@class, 'font-size-80-33')]/span[contains(@class, 'museo-sans-light')][text()='From Taming Cloud Complexity to Achieving Cloud Mastery']");

    }
 }
