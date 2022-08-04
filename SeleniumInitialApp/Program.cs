using GmailClient.Pages.Gmail;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumInitialApp
{
    class Program
    {
        const string GmailEmailAddress = "lesnoykulik@gmail.com";
        const string GmailPassword = "123ewqASDcxz";
        const string MailRuEmailAddress = "udodudodovich@mail.ru";
        const string MailRuPassword = "cxzASDewq123567";
        const string EmailSubject = "Test mail clients";

        static void Main(string[] args)
        {
            WebDriver webDriver = new ChromeDriver { Url = "https://www.google.com/intl/ru/gmail/about/" };
            GmailHomePage gmailHomePage = new GmailHomePage(webDriver);
            GmailLoginPage gmailLoginPage = gmailHomePage.GoToLoginPage();

            GmailMailBoxPage gmailBoxPage = gmailLoginPage.Login(GmailEmailAddress, GmailPassword);
            gmailBoxPage.SendMail(MailRuEmailAddress, EmailSubject);
            gmailBoxPage.CheckMailIsSentToRecipient();

            //webDriver.Close();
            //webDriver.Dispose();

            /*WebDriver gmailDriver = new ChromeDriver
            {
                Url = "https://gmail.com/"
                //https://www.google.com/intl/ru/gmail/about/
            };

            gmailDriver.Manage().Window.Maximize();

            gmailDriver.FindElement(By.Id("identifierId")).SendKeys("lesnoykulik@gmail.com");

            gmailDriver.FindElement(By.Id("identifierNext")).Click();

            gmailDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);

            var passwordInput = gmailDriver.FindElement(By.Name("password"));

            passwordInput.Click();
            passwordInput.SendKeys("123ewqASDcxz");

            gmailDriver.FindElement(By.Id("passwordNext")).Click();

            gmailDriver.FindElement(By.XPath("//div[@class='T-I T-I-KE L3']")).Click();

            gmailDriver.FindElement(By.XPath("//textarea[@aria-label='Кому']")).SendKeys("udodudodovich@mail.ru");

            gmailDriver.FindElement(By.XPath("//input[@placeholder='Тема']")).SendKeys("Test mail");

            var submitButton = gmailDriver.FindElement(By.XPath("//div[contains(text(), 'Отправить') and @role='button']"));

            submitButton.Click();

            WebDriver mailRuDriver = new ChromeDriver
            {
                Url = "https://mail.ru/"
            };

            mailRuDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);

            mailRuDriver.Manage().Window.Maximize();

            mailRuDriver.FindElement(By.XPath("//button[contains(text(), 'Войти')]")).Click();

            var iframe = mailRuDriver.FindElement(By.CssSelector("iframe.ag-popup__frame__layout__iframe"));

            mailRuDriver.SwitchTo().Frame(iframe);

            mailRuDriver.FindElement(By.XPath("//input[@name='username']")).SendKeys("udodudodovich");

            mailRuDriver.FindElement(By.XPath("//span[contains(text(), 'Enter password')]")).Click();

            mailRuDriver.FindElement(By.XPath("//input[@name='password']")).SendKeys("cxzASDewq123567");

            mailRuDriver.FindElement(By.XPath("//span[contains(text(), 'Sign in')]")).Click();
            */
        }
    }
}
