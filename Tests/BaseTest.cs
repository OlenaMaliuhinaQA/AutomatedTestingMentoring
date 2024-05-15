using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
public class BaseTest
{
    public IWebDriver driver;
    [SetUp]
    public void Setup()
    {
        driver = new ChromeDriver();
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