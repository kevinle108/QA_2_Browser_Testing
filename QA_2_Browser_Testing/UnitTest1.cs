using FluentAssertions;
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

                // QR Code Generator
                // https://qreader.online/

                // QR Code Readers
                // https://qreader.online/
                // https://me-qr.com/
                // https://4qrcode.com/scan-qr-code.php

                string title = driver.Title;

                title.Should().Be("Svelte • Cybernetically enhanced web apps");
                //title.Should().Be("Docs • Svelte");

            }
        }
    }
}