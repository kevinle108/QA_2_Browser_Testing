using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace QA_2_Browser_Testing
{
    public class UnitTest1
    {
        [Fact]
        [Trait("Category", "Example")]
        public void LoadPage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("https://www.redfin.com/KY/Louisville/8110-Kellerman-Rd-40219/home/71182885");

                // QR Code Generator
                // https://me-qr.com/
                // https://www.qr-code-generator.com/
                // Date Picker
                // https://qrickit.com/qrickit_apps/qrickit_qrcode_creator_vcal.php
                // https://www.qrcodechimp.com/qr-code-generator-for-event
                List<String> names = new()
                {
                    "Kevin", "Le"
                };

                names.Should().StartWith(names);


                // EXPLICIT WAIT EXAMPLE
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1));
                IWebElement applyLink =
                    wait.Until(d => d.FindElement(By.LinkText("Easy: Apply Now!")));
                

                // QR Code Readers
                // https://qreader.online/
                // https://me-qr.com/
                // https://4qrcode.com/scan-qr-code.php

                string title = driver.Title;
                IWebElement houseinfo = driver.FindElement(By.Id("house-info"));

                title.Should().Be("8110 Kellerman Rd, Louisville, KY 40219 | MLS# 1631002 | Redfin");
                houseinfo.Text.Should().Be("");
                //title.Should().Be("Docs • Svelte");

            }
        }

        [Fact]
        [Trait("Category", "Example")]
        public void Example_Explicit_Wait()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("https://www.redfin.com/KY/Louisville/8110-Kellerman-Rd-40219/home/71182885");

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1));
                IWebElement applyLink =
                    wait.Until(d => d.FindElement(By.LinkText("Easy: Apply Now!")));
            }
        }

        [Fact]
        [Trait("Category", "Example")]
        public void Example_Prebuilt_Conditions()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("https://www.redfin.com/KY/Louisville/8110-Kellerman-Rd-40219/home/71182885");                
                
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1));
                IWebElement applyLink =
                    wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("Easy: Apply Now!")));
                applyLink.Click();
            }
        }

        [Fact]
        [Trait("Category", "Example")]
        public void Example_Prebuilt_Conditions()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("https://www.redfin.com/KY/Louisville/8110-Kellerman-Rd-40219/home/71182885");

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1));
                IWebElement applyLink =
                    wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("Easy: Apply Now!")));
                applyLink.Click();
            }
        }
    }
}