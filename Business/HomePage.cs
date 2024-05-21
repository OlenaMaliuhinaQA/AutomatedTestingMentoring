﻿using OpenQA.Selenium;
using System.Xml.Linq;

namespace PageObjectTask.PageObjects
{
    public class HomePage : BasePage
    {
        private IWebDriver driver;
        public HomePage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }
        public IWebElement magnifierIcon => driver.FindElement(By.XPath("//span[contains(@class, 'search-icon') and contains(@class, 'dark-iconheader-search__search-icon')]"));
        public IWebElement searchInput => driver.FindElement(By.Id("new_form_search"));
        public IWebElement findButton => driver.FindElement(By.XPath("//span[contains(text(), 'Find')]"));

        public XElement homePageContent = XElement.Parse("<div class=\"search-results__items\">...</div>");
        public IWebElement acceptCookiesButton => driver.FindElement(By.XPath("//button[@id='onetrust-accept-btn-handler']"));
    }
}