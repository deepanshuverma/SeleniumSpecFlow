using System;
using OpenQA.Selenium;

namespace AudenTest.Pages.Credit.ShortTermLoan
{
    public class PrivacyPromptModal
    {
        IWebDriver driver;

        public By PrivacyPrompt = By.CssSelector(".privacy_prompt");
        public By btnAccept = By.CssSelector("");

        public PrivacyPromptModal(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
