using OpenQA.Selenium;

public interface IUIDriver
{
    public IWebDriver GetDriver();
    public void StartConnection();
    public void StopConnection();
}