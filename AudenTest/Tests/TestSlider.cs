using AudenTest.Pages.Credit.ShortTermLoan;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AudenTest.Tests
{
    public class TestSlider
    {
        [Test]
        public void SliderTest()
        {
            IWebDriver driver = new ChromeDriver();
            
            driver.Url = "https://auden.co.uk/Credit/ShortTermLoan";

            var ShortTerLoanPage = new ShortTermLoan(driver);
            

        }
    }
}
