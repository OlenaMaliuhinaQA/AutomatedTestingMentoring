using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace PageObjectTask.Core
{
    public class DriverHelper
    {
        private IWebDriver driver;
        public WebDriverWait wait;

        public DriverHelper(IWebDriver driver)
        {
            this.driver = driver;
            //driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
       

        }

        public static void waitForPageLoading() 
        {
        //do we need it?


        }   
    }
}
