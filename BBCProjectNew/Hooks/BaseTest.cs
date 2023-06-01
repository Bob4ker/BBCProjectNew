using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Reflection;
using TechTalk.SpecFlow;

namespace BBCProjectNew.Hooks
{
    [Binding]
    public class BaseTest
    {
        public static IWebDriver driver;

        [BeforeScenario]
        
        public void BeforeScenarioWithTag()
        {
           
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        //[BeforeScenario(Order = 1)]
        //public void FirstBeforeScenario()
        //{
       
        //}

        [AfterScenario]
        public void AfterScenario()
        {
            Thread.Sleep(5000);
            // driver.Close();
             driver.Quit();

        }
    }
}