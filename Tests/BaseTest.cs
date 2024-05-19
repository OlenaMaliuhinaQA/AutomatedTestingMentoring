using log4net;
using log4net.Config;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using PageObjectTask.PageObjects;
public class BaseTest
{
    private IWebDriver driver;
    public WebDriverWait wait;
    public HomePage homePage;
    public CareerPage careerPage;
    public AboutPage aboutPage;
    public ArticlePage articlePage;
    public InsightsPage insightsPage;
    
    [SetUp]
    public void Setup()
    {
        driver = new ChromeDriver();
        wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

        homePage = new HomePage(driver);
        careerPage = new CareerPage(driver);
        aboutPage = new AboutPage(driver);
        articlePage = new ArticlePage(driver);
        insightsPage = new InsightsPage(driver);
        driver.Navigate().GoToUrl(@"https://www.epam.com/");
        driver.Manage().Window.Maximize();
        homePage.acceptCookiesButton.Click();
    }

    [TearDown]
    public void TearDown()
    {
        driver.Quit();
        driver.Dispose();
    }

    [SetUpFixture]
    public class SetUpFixture
    {
        [SetUp]
        public void BeforeAllTests()
        {
            XmlConfigurator.Configure(new FileInfo("Log.config"));
        }
    }
}

