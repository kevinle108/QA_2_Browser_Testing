using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace QA_2_Browser_Testing
{
    public class UnitTest1
    {
        [Fact]
        [Trait("Category", "Smoke")]
        public void LoadPage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("https://svelte.dev/");
            }
        }
    }
}