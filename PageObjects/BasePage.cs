using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectTask.PageObjects
{
    public class BasePage
    {
        // locators : tabs, darkmode button, options ..
        // actions: GoToCareerTab
        public By acceptButton = By.Id("onetrust-accept-btn-handler");
        public By careerTab = By.XPath("//a[text()='Careers']");
        public By servicesTab = By.XPath("//a[text()='Services']");
        public By insightsTab = By.XPath("//a[text()='Insights']");
        public By aboutTab = By.XPath("//a[text()='About']");
    }
}
