using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

public class FirefoxUIDriver : IUIDriver
{
    public IWebDriver driver;


    public void StartConnection()
    {
        driver = new FirefoxDriver();
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