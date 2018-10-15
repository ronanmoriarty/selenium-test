using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;

namespace SampleMVCSite.Test
{
    [TestFixture]
    public class SeleniumIssue
    {
        [Test]
        public void Passes_when_run_on_host_but_fails_in_docker_container()
        {
            var driver = CreateWebDriver();
            driver.Navigate().GoToUrl("http://localhost:5808/");
            driver.FindElement(By.ClassName("container"));
        }

        public RemoteWebDriver CreateWebDriver()
        {
            var firefoxOptions = new FirefoxOptions
            {
                LogLevel = FirefoxDriverLogLevel.Debug
            };
            firefoxOptions.AddArgument("--headless");
            firefoxOptions.SetLoggingPreference(LogType.Driver, LogLevel.Debug);
            firefoxOptions.SetLoggingPreference(LogType.Browser, LogLevel.Debug);

            return new FirefoxDriver(FirefoxDriverService.CreateDefaultService(), firefoxOptions);
        }
    }
}
