using TestFramework.Pages.Gmail;
using TestFramework.Pages.MailRu;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumInitialApp
{
    class Program
    {
        const string GmailEmailAddress = "lesnoykulik@gmail.com";
        const string GmailPassword = "123ewqASDcxz";
        const string MailRuEmailAddress = "udodudodovich@mail.ru";
        const string MailRuUsername = "udodudodovich@mail.ru";
        const string MailRuPassword = "cxzASDewq123567";
        const string EmailSubject = "Test mail clients";

        static void Main(string[] args)
        {
            WebDriver webDriver1 = new ChromeDriver { Url = "https://www.google.com/intl/ru/gmail/about/" };
            webDriver1.Manage().Window.Maximize();

            GmailHomePage gmailHomePage = new GmailHomePage(webDriver1);
            GmailLoginPage gmailLoginPage = gmailHomePage.GoToLoginPage();

            GmailMailBoxPage gmailBoxPage = gmailLoginPage.Login(GmailEmailAddress, GmailPassword);
            gmailBoxPage.SendMail(MailRuEmailAddress, EmailSubject);
            gmailBoxPage.CheckMailIsSentToRecipient();

            WebDriver webDriver2 = new ChromeDriver { Url = "https://mail.ru/" };
            webDriver2.Manage().Window.Maximize();
            MailRuHomePage mailRuHomePage = new MailRuHomePage(webDriver2);
            MailRuMailBoxPage mailRuMailBoxPage = mailRuHomePage.Login(MailRuUsername, MailRuPassword);
            mailRuMailBoxPage.ReplyToMailOnMailSubject(GmailEmailAddress, EmailSubject);

            webDriver1.Close();
            webDriver1.Dispose();
            webDriver2.Close();
            webDriver2.Dispose();
        }
    }
}
