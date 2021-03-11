using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace AudenTest.Pages.Credit.ShortTermLoan
{
    public class ShortTermLoan
    {
        private IWebDriver driver;
        
        public By Slider = By.XPath("//input[@data-testid='loan - calculator - slider']");


        public By DateSelector = By.XPath("//input[@data-testid='loan-calculator-date-selector']");
        

        public By LoanSummary = By.XPath("//input[@data-testid='loan-calculator-summary-amount']");                 
                
        public ShortTermLoan(IWebDriver driver)
        {
            this.driver = driver;
        }

        public bool SelectDate(string selectedDate)
        {
            IEnumerable<IWebElement> dates = driver.FindElements(DateSelector);
            foreach (IWebElement date in dates)
            {
                var dateValue = date.GetAttribute("value");

                if (string.Equals(dateValue, selectedDate))
                {
                    date.Click();
                    return true;
                }
            }
            return false;

        }

        public void SetSliderAmount(int amount)
        {
            
            IWebElement slider = driver.FindElement(Slider);
            var Pixels = GetPixelsToMove(slider,amount,500,200);

            Actions SliderAction = new Actions(driver);

            SliderAction.ClickAndHold(slider)
                .MoveByOffset(-(int)slider.Size.Width / 2, 0)
                .MoveByOffset(Pixels, 0).Release().Perform();
        }

        private static int GetPixelsToMove(IWebElement Slider, decimal Amount, decimal SliderMax, decimal SliderMin)
        {
            int pixels = 0;
            decimal tempPixels = Slider.Size.Width;
            tempPixels = tempPixels / (SliderMax - SliderMin);
            tempPixels = tempPixels * (Amount - SliderMin);
            pixels = Convert.ToInt32(tempPixels);
            return pixels;
        }

    }
}
