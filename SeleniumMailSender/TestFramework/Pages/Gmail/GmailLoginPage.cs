using GmailClient.Extensions;
using OpenQA.Selenium;

namespace GmailClient.Pages.Gmail
{
    public class GmailLoginPage : WebPageBase
    {
        public const string BaseURL = "https://accounts.google.com/signin/v2/identifier";

        public static readonly By UsernameInputSelector = By.Id("identifierId");
        public static readonly By UsernameSubmitButtonSelector = By.CssSelector("#identifierNext button");
        public static readonly By PasswordInputSelector = By.CssSelector("#password input");
        public static readonly By PasswordSubmitButtonSelector = By.CssSelector("#passwordNext button");

        public GmailLoginPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        public GmailMailBoxPage Login(string username, string password)
        {
            WebDriver.WaitForElement(UsernameInputSelector, DefaultTimeout).SendKeys(username);
            WebDriver.WaitForClickableElement(UsernameSubmitButtonSelector, DefaultTimeout).Click();
            WebDriver.WaitForElement(PasswordInputSelector, DefaultTimeout).SendKeys(password);
            WebDriver.WaitForClickableElement(PasswordSubmitButtonSelector, DefaultTimeout).Click();
            WebDriver.WaitUntilPageIsLoaded(GmailMailBoxPage.BaseURL, DefaultTimeout);
            return new GmailMailBoxPage(WebDriver);
        }
    }
}
