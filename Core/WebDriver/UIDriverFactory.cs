public class UIDriverFactory
{
    public IUIDriver Create(BrowserType type)
    {
        switch (type)
        {
            case BrowserType.Chrome:
                return new ChromeUIDriver();
            case BrowserType.Firefox:
                return new FirefoxUIDriver();
            default:
                throw new ArgumentException("DRIVER NOT IMPLEMENTED");
        }
    }

}
public enum BrowserType
{
    Chrome, Firefox
}