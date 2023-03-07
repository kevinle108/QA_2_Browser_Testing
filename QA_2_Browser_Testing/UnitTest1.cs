using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using QA_2_Browser_Testing.PageObjectModels;
using SeleniumExtras.WaitHelpers;

namespace QA_2_Browser_Testing
{
    // Generate, then Read
    // https://4qrcode.com/ + https://4qrcode.com/scan-qr-code.php

    // QR Code Readers
    // https://qreader.online/
    // https://me-qr.com/
    // https://4qrcode.com/scan-qr-code.php                

    // Tooltip6
    // https://me-qr.com/ + https://me-qr-scanner.com/qr-scanner#scan-using-file


    // File Download
    // https://www.youtube.com/watch?v=w1QA5-rYELg
    // https://www.youtube.com/watch?v=_8fwyB0t5Ac


    public class UnitTest1
    {
        [Fact]
        public void LoadPage_()
        {
            using (IWebDriver driver = new ChromeDriver()) 
            {
                driver.Navigate().GoToUrl("https://4qrcode.com/");

                var homePage = new HomePage(driver);

                homePage.EventButton.Click();

                Thread.Sleep(2000);

                
                //string title = driver.Title;
                //IWebElement houseinfo = driver.FindElement(By.Id("house-info"));

                //title.Should().Be("8110 Kellerman Rd, Louisville, KY 40219 | MLS# 1631002 | Redfin");
                //houseinfo.Text.Should().Be("");
                //title.Should().Be("Docs • Svelte");

            }
        }
       

        // TODO: Remove this
        //[Fact]
        //[Trait("Category", "Example")]
        //public void Example_Explicit_Wait()
        //{
        //    using (IWebDriver driver = new ChromeDriver())
        //    {
        //        driver.Navigate().GoToUrl("https://www.redfin.com/KY/Louisville/8110-Kellerman-Rd-40219/home/71182885");

        //        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1));
        //        IWebElement applyLink =
        //            wait.Until(d => d.FindElement(By.LinkText("Easy: Apply Now!")));
        //    }
        //}

        //[Fact]
        //[Trait("Category", "Example")]
        //public void Example_Prebuilt_Conditions()
        //{
        //    using (IWebDriver driver = new ChromeDriver())
        //    {
        //        driver.Navigate().GoToUrl("https://www.redfin.com/KY/Louisville/8110-Kellerman-Rd-40219/home/71182885");                
                
        //        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1));
        //        IWebElement applyLink =
        //            wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("Easy: Apply Now!")));
        //        applyLink.Click();
        //    }
        //}
    }
}