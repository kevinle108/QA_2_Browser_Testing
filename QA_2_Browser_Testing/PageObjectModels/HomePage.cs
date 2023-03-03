using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_2_Browser_Testing.PageObjectModels
{
    internal class HomePage
    {
        private readonly IWebDriver Driver;

        public HomePage(IWebDriver driver)
        {
            Driver = driver;
        }
        
        public IWebElement SampleElement
        {
            get
            {
                return Driver.FindElement(By.Id("house-info"));
            }
        }

    }
}
