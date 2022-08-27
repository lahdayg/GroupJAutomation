using System;
using TechTalk.SpecFlow;
using TestingGroupJ.PageObject;

namespace TestingGroupJ.StepDefinition
{
    [Binding]
    public class DataDrivenWithExampleSteps
    {
        DataDrivenWithExamplePage dataDrivenWithExamplePage;

        public DataDrivenWithExampleSteps()
        {
            dataDrivenWithExamplePage = new DataDrivenWithExamplePage();
        }



        [Given(@"I enter my Username text ""(.*)""")]
        public void GivenIEnterMyUsernameText(string Username)
        {
            dataDrivenWithExamplePage.EnterUsername(Username);
        }
        
        [Given(@"I enter my email text ""(.*)""")]
        public void GivenIEnterMyEmailText(string Email)
        {
            dataDrivenWithExamplePage.EnterEmail(Email);
        }
        
        [Given(@"I enter my password text ""(.*)""")]
        public void GivenIEnterMyPasswordText(string Password)
        {
            dataDrivenWithExamplePage.EnterPassword(Password);
        }
    }
}
