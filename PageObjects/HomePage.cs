﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectTask.PageObjects
{
    public class HomePage : BasePage
    {
        public By magnifierIcon = By.XPath("//span[contains(@class, 'search-icon') and contains(@class, 'dark-iconheader-search__search-icon')]");
        public By searchInput = By.Id("new_form_search");
        public By findButton = By.XPath("//span[contains(text(), 'Find')]");

    }
}
