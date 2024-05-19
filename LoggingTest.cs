public class Logging : BaseTest
{
    [Test]
    public void LoggingTest()
    {
        Console.WriteLine("test");
        Log.Debug("Hello World of Logging :) ...");
    }
}