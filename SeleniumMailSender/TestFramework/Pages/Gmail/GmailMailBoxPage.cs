using GmailClient.Extensions;
using OpenQA.Selenium;

namespace GmailClient.Pages.Gmail
{
    public class GmailMailBoxPage : WebPageBase
    {
        public const string BaseURL = "https://mail.google.com/mail";

        public static readonly By WriteMailButtonSelector = By.XPath("//div[contains(text(), 'Написать') and @role='button']");
        public static readonly By MailAddressToSelector = By.XPath("//textarea[@aria-label='Кому']");
        public static readonly By MailSubjectSelector = By.XPath("//input[@placeholder='Тема']");
        public static readonly By SendMailButtonSelector = By.XPath("//div[contains(text(), 'Отправить') and @role='button']");
        public static readonly By SentMailsLinkSelector = By.XPath("//a[@href='https://mail.google.com/mail/u/0/#sent']");

        public GmailMailBoxPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        public void SendMail(string mailAddressTo, string mailSubject)
        {
            WebDriver.WaitForClickableElement(WriteMailButtonSelector, DefaultTimeout).Click();
            WebDriver.WaitForElement(MailAddressToSelector, DefaultTimeout).SendKeys(mailAddressTo);
            WebDriver.WaitForElement(MailSubjectSelector, DefaultTimeout).SendKeys(mailSubject);
            WebDriver.WaitForClickableElement(SendMailButtonSelector, DefaultTimeout).Click();
        }

        public void CheckMailIsSentToRecipient()
        {
            WebDriver.WaitForClickableElement(SentMailsLinkSelector, DefaultTimeout).Click();
        }
    }
}
