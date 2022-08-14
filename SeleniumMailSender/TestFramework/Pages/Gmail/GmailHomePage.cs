using OpenQA.Selenium;
using TestFramework.Extensions;

namespace TestFramework.Pages.Gmail
{
    public class GmailHomePage : WebPageBase
    {
        public static readonly By LoginButtonSelector = By.XPath("//a[contains(text(), 'Войти')]");

        public GmailHomePage(IWebDriver webDriver) : base(webDriver)
        {
        }

        public GmailLoginPage GoToLoginPage()
        {
            WebDriver.WaitForClickableElement(LoginButtonSelector, DefaultTimeout).Click();
            WebDriver.WaitUntilPageIsLoaded(GmailLoginPage.BaseURL, DefaultTimeout);
            return new GmailLoginPage(WebDriver);
        }
    }
}
