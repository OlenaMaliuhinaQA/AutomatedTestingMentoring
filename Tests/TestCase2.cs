using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using PageObjectTask.PageObjects;
using System.Xml.XPath;

namespace PageObjectTask.Tests
{

    public class Tests2 : BaseTest
    {

        [Test]
        [TestCase("BLOCKCHAIN/Cloud/Automation")]
        public void Test2(string searchItem)
        {
            BasePage basePage = new BasePage(); // creating an instance of the base page
            HomePage homePage = new HomePage();

            //2.	Find a magnifier icon and click on it
             driver.FindElement(homePage.magnifierIcon).Click();

            //3. Find a search string and put there “BLOCKCHAIN”/”Cloud”/”Automation” (use as a parameter for a test)

            //IWebElement inputElement = driver.FindElement(By.Id("new_form_search"));
            IWebElement inputElement = driver.FindElement(homePage.searchInput);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            wait.Until(d => inputElement.Displayed);
            inputElement.Clear();
            inputElement.SendKeys(searchItem);

            //4.Click “Find” button
            driver.FindElement(homePage.findButton).Click();

            string htmlContent = "<div class=\"search-results__items\">...</div>";

            // Load the HTML content into an XElement
            XElement root = XElement.Parse(htmlContent);

            // Query to check if all <article> elements contain the specified words
            bool allContainWords = root.XPathSelectElements("//article")
                .All(article =>
                    article.Value.Contains("BLOCKCHAIN", StringComparison.OrdinalIgnoreCase) ||
                    article.Value.Contains("Cloud", StringComparison.OrdinalIgnoreCase) ||
                    article.Value.Contains("Automation", StringComparison.OrdinalIgnoreCase));

            // Assert if all <article> elements contain the specified words
            if (allContainWords)
            {
                Assert.Pass("All <article> elements contain the specified words.");
            }
            else
            {
                Assert.Fail("Not all <article> elements contain the specified words.");
            }


        }

    }
}