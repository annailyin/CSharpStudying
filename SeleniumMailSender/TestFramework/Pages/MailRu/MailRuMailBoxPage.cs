using OpenQA.Selenium;
using System.Linq;
using TestFramework.Extensions;

namespace TestFramework.Pages.MailRu
{
    public class MailRuMailBoxPage : WebPageBase
    {
        public const string BaseURL = "https://e.mail.ru/inbox";

        public static readonly By InboxLinkSelector = By.XPath("//a[@class='ph-project svelte-jq5qv5 ph-project_current']");

        public static readonly By ReplyButtonSelector = By.XPath("//span[contains(@class, 'button2_reply')]");

        public static readonly By SendButtonSelector = By.XPath("//button[@data-test-id='send']");

        public static readonly By SendEmptyMailButtonSelector = By.XPath("//button[@class='base-0-2-14 primary-0-2-28 auto-0-2-40']");

        public MailRuMailBoxPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        public void ReplyToMailOnMailSubject(string emailAddress, string mailSubject)
        {           
            WebDriver.WaitForClickableElement(InboxLinkSelector, DefaultTimeout).Click();
            var emailItemSelector = BuildEmailItemSelector(emailAddress);
            WebDriver.WaitForClickableElement(emailItemSelector, DefaultTimeout).Click();
            WebDriver.WaitForClickableElement(ReplyButtonSelector, DefaultTimeout).Click();
            WebDriver.WaitForClickableElement(SendButtonSelector, DefaultTimeout).Click();
            WebDriver.WaitForClickableElement(SendEmptyMailButtonSelector, DefaultTimeout).Click();
        }

        private By BuildEmailItemSelector(string emailAddress)
        {
            return By.XPath($"//a[contains(@class, 'js-letter-list-item') and .//span[contains(@title, '<{emailAddress}>')]]");
        }
    }
}
