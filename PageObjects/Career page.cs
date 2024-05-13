using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectTask.PageObjects
{
    public class CareerPage : BasePage
    {
        public By keywordInput = By.XPath("//*[@id='new_form_job_search-keyword']");
        public By locationDropdown = By.XPath("//span[@class='select2-selection__arrow']");
        public By DropdownOptionByCountryName(string countryName) => By.XPath($"//li[@title='{countryName}']");
        public By remoteCheckBox = By.CssSelector("label.recruiting-search__filter-label-23.checkbox-custom-label.body-text-small[for='id-93414a92-598f-316d-b965-9eb0dfefa42d-remote']\r\n");
        public By findButton = By.XPath("//button[@type='submit' and contains(text(),'Find')]");
        public By lastElementInList = By.XPath("//ul[@class=\"search-result__list\"]/li[last()]");
        public By findAllSearchResultItems = By.XPath("//ul[@class='search-result__list']/li[contains(@class, 'search-result__item')]");
        public By viewAndApplyButton = By.XPath(".//a[contains(@class, 'search-result__item-apply-23')]");
        public By vacancyContent = By.XPath("//div[@class='vacancy-details-23__vacancy-content vacancy_content']");
    }
}
