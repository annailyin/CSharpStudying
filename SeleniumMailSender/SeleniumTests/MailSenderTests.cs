using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestFramework.Pages.Gmail;
using TestFramework.Pages.MailRu;

namespace SeleniumTests
{
    [TestClass]
    public class MailSenderTests
    {
        const string GmailEmailAddress = "lesnoykulik@gmail.com";
        const string GmailPassword = "123ewqASDcxz";
        const string MailRuEmailAddress = "udodudodovich@mail.ru";
        const string MailRuUsername = "udodudodovich@mail.ru";
        const string MailRuPassword = "cxzASDewq123567";
        const string EmailSubject = "Test mail clients";
        const string GmailUrl = "https://www.google.com/intl/ru/gmail/about/";
        const string MailRuUrl = "https://mail.ru/";

        [TestMethod]
        public void CheckGMailSender()
        {
            WebDriver webDriver = new ChromeDriver { Url = GmailUrl };
            webDriver.Manage().Window.Maximize();

            GmailHomePage gmailHomePage = new GmailHomePage(webDriver);
            GmailLoginPage gmailLoginPage = gmailHomePage.GoToLoginPage();

            GmailMailBoxPage gmailBoxPage = gmailLoginPage.Login(GmailEmailAddress, GmailPassword);
            gmailBoxPage.SendMail(MailRuEmailAddress, EmailSubject);
            gmailBoxPage.CheckMailIsSentToRecipient();

            webDriver.Close();
            webDriver.Dispose();
        }

        [TestMethod]
        public void CheckMailRuSender()
        {
            WebDriver webDriver = new ChromeDriver { Url = MailRuUrl };
            webDriver.Manage().Window.Maximize();

            MailRuHomePage mailRuHomePage = new MailRuHomePage(webDriver);
            MailRuMailBoxPage mailRuMailBoxPage = mailRuHomePage.Login(MailRuUsername, MailRuPassword);
            mailRuMailBoxPage.ReplyToMailOnMailSubject(GmailEmailAddress, EmailSubject);

            webDriver.Close();
            webDriver.Dispose();
        }
    }
}
