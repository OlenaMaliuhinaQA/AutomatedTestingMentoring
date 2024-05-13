using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using PageObjectTask.PageObjects;
public class BaseTest
{
    private IWebDriver driver;
    public HomePage homePage;
    public CareerPage careerPage;
    public AboutPage aboutPage;
    public ArticlePage articlePage;
    public InsightsPage insightsPage;
    [SetUp]
    public void Setup()
    {
        driver = new ChromeDriver();

        homePage = new HomePage(driver);
        careerPage = new CareerPage();
        aboutPage = new AboutPage();
        articlePage = new ArticlePage();
        insightsPage = new InsightsPage();
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        driver.Navigate().GoToUrl(@"https://www.epam.com/");
        driver.Manage().Window.Maximize();
    }

    [TearDown]
    public void TearDown()
    {
        driver.Quit();
        driver.Dispose();
    }
}