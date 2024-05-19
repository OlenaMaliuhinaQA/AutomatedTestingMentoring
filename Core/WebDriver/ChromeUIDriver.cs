using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class ChromeUIDriver : IUIDriver
{
    private IWebDriver driver;

    public void StartConnection()
    {
        driver = new ChromeDriver();
    }

    public void StopConnection()
    {
        driver.Quit();
        driver.Dispose();
    }


    public IWebDriver GetDriver()
    {
        return driver;
    }
}