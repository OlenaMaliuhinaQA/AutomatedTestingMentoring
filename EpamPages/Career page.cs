using OpenQA.Selenium;

namespace PageObjectTask.PageObjects
{
    public class CareerPage : BasePage
    {
        private IWebDriver driver;
        public CareerPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }
        public IWebElement keywordInput => driver.FindElement(By.XPath("//*[@id='new_form_job_search-keyword']"));
        public IWebElement locationDropdown => driver.FindElement(By.XPath("//span[@class='select2-selection__arrow']"));
        public IWebElement DropdownOptionByCountryName(string countryName) => driver.FindElement(By.XPath($"//li[@title='{countryName}']"));
        public IWebElement remoteCheckBox => driver.FindElement(By.CssSelector("label.recruiting-search__filter-label-23.checkbox-custom-label.body-text-small[for='id-93414a92-598f-316d-b965-9eb0dfefa42d-remote']\r\n"));
        public IWebElement findButton => driver.FindElement(By.XPath("//button[@type='submit' and contains(text(),'Find')]"));
        public IWebElement lastElementInList => driver.FindElement(By.XPath("//ul[@class=\"search-result__list\"]/li[last()]"));
        public IList<IWebElement> findAllSearchResultItems => driver.FindElements(By.XPath("//ul[@class='search-result__list']/li[contains(@class, 'search-result__item')]"));
        public By viewAndApplyButton => By.XPath(".//a[contains(@class, 'search-result__item-apply-23')]");
        public IWebElement vacancyContent => driver.FindElement(By.XPath("//div[@class='vacancy-details-23__vacancy-content vacancy_content']"));
    }
}