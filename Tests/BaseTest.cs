using log4net;
using log4net.Config;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using PageObjectTask.PageObjects;
public class BaseTest
{
    public IUIDriver uiDriver;
    public WebDriverWait wait;
    public HomePage homePage;
    public CareerPage careerPage;
    public AboutPage aboutPage;
    public ArticlePage articlePage;
    public InsightsPage insightsPage;
    protected ILog Log;

    [SetUp]
    public void Setup()
    {
        XmlConfigurator.Configure(new FileInfo("Tests/Log.config"));
        Log = LogManager.GetLogger(this.GetType());
        uiDriver = new UIDriverFactory().Create(BrowserType.Chrome);
        uiDriver.StartConnection();
        wait = new WebDriverWait(uiDriver.GetDriver(), TimeSpan.FromSeconds(20));
        homePage = new HomePage(uiDriver.GetDriver());
        careerPage = new CareerPage(uiDriver.GetDriver());
        aboutPage = new AboutPage(uiDriver.GetDriver());
        articlePage = new ArticlePage(uiDriver.GetDriver());
        insightsPage = new InsightsPage(uiDriver.GetDriver());
        uiDriver.GetDriver().Navigate().GoToUrl(@"https://www.epam.com/");
        uiDriver.GetDriver().Manage().Window.Maximize();
        homePage.acceptCookiesButton.Click();
    }

    [TearDown]
    public void TearDown()
    {
        uiDriver.StopConnection();
    }
}

