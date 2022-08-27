using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TestingGroupJ.Utilities;

namespace TestingGroupJ.PageObject
{
    class DataDrivenWithExamplePage
    {

        public DataDrivenWithExamplePage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;


        IWebElement UsernameText => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > fieldset:nth-child(1) > input"));
        IWebElement EmailText => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[2]/input"));
        IWebElement PasswordText => driver.FindElement(By.XPath("//input[@placeholder='Password']"));
        IWebElement NewArticle => driver.FindElement(By.XPath("(//a[@class='nav-link'])[3]"));





        public void EnterUsername(string Username)
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            UsernameText.SendKeys(Username + randomInt);
            //Username.SendKeys(username);
        }

        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void EnterEmail(string Email)
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            EmailText.SendKeys(Email + randomInt + "@gmail.com");
            //Email.SendKeys(email);
        }

        public void EnterPassword(string Password)
        {
            PasswordText.SendKeys(Password);
        }


        public bool IsNewArticleDisplayed()
        {
            return NewArticle.Displayed;
        }





























    }
}
