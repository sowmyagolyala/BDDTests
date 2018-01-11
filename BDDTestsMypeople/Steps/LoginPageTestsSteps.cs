using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace BDDTestsMypeople.Steps
{
    [Binding]
    public class LoginPageTestsSteps
    {
        public static IWebDriver driver;
        [Given(@"I'm on Login page")]
        public void GivenIMOnLoginPage()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://test-data.mypeoplemanager.com/");
        }
        
        [Given(@"I have entered valid username and password")]
        public void GivenIHaveEnteredValidUsernameAndPassword()
        {
            driver.FindElement(By.Id("Email")).SendKeys("jonathan.norman@mypeoplemanager.co.uk");
            driver.FindElement(By.Id("Password")).SendKeys("V6TVy53DZrbB!jF");
        }
        
        [When(@"I hit login button")]
        public void WhenIHitLoginButton()
        {
            driver.FindElement(By.XPath("//button[@value='Log in']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        
        [Then(@"I should login successfully")]
        public void ThenIShouldLoginSuccessfully()
        {
            driver.FindElement(By.CssSelector("i.caret")).Click();
            true.Equals(driver.FindElement(By.XPath("//div[@id='wrapper']/div[3]/div/ul/li[5]/button")).Displayed);
            
        }
        [When(@"user hits Signout button")]
        public void WhenUserHitsSigoutButton()
        {
            driver.FindElement(By.XPath("//div[@id='wrapper']/div[3]/div/ul/li[5]/button")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [Then(@"user should logout Successfully")]
        public void ThenUserShouldLogoutSuccessfully()
        {
            true.Equals(driver.FindElement(By.XPath("//button[@value='Log in']")).Displayed);
            driver.Close();
        }



    }




}
