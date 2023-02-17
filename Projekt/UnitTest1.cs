using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using static System.Collections.Specialized.BitVector32;

namespace SeleniumTests
{
    [TestFixture]
    public class UnitTest
    {
        private Actions act;
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "https://www.google.com/";
            verificationErrors = new StringBuilder();
            act = new Actions(driver);
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheRegisterTest()
        {
            driver.Navigate().GoToUrl("https://magento.softwaretestingboard.com/");
            driver.FindElement(By.LinkText("Create an Account")).Click();
            driver.FindElement(By.Id("firstname")).Click();
            driver.FindElement(By.Id("firstname")).Clear();
            driver.FindElement(By.Id("firstname")).SendKeys("A");
            driver.FindElement(By.Id("lastname")).Clear();
            driver.FindElement(By.Id("lastname")).SendKeys("A");
            driver.FindElement(By.Id("email_address")).Click();
            driver.FindElement(By.Id("email_address")).Clear();
            driver.FindElement(By.Id("email_address")).SendKeys("testiranje3@testiranje.com");
            driver.FindElement(By.Id("password")).Clear();
            driver.FindElement(By.Id("password")).SendKeys("Testiranje1");
            driver.FindElement(By.Id("password-confirmation")).Click();
            driver.FindElement(By.Id("password-confirmation")).Clear();
            driver.FindElement(By.Id("password-confirmation")).SendKeys("Testiranje1");
            driver.FindElement(By.XPath("//form[@id='form-validate']/div/div/button/span")).Click();
        }

        [Test]
        public void TheLoginTest()
        {
            driver.Navigate().GoToUrl("https://magento.softwaretestingboard.com/");
            driver.FindElement(By.LinkText("Sign In")).Click();
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("testiranje1@testiranje.com");
            driver.FindElement(By.Id("pass")).Clear();
            driver.FindElement(By.Id("pass")).SendKeys("Testiranje1");
            driver.FindElement(By.XPath("//button[@id='send2']/span")).Click();
        }

        [Test]
        public void TheShoppingCartTest()
        {
            driver.Navigate().GoToUrl("https://magento.softwaretestingboard.com/");
            driver.FindElement(By.LinkText("Sign In")).Click();
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("testiranje1@testiranje.com");
            driver.FindElement(By.Id("pass")).Clear();
            driver.FindElement(By.Id("pass")).SendKeys("Testiranje1");
            driver.FindElement(By.XPath("//button[@id='send2']/span")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//a[@id='ui-id-6']/span[2]")).Click();
            driver.FindElement(By.XPath("//a[contains(text(),'Bags')]")).Click();
            driver.FindElement(By.XPath("//img[@alt='Image']")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.Id("product-addtocart-button")).Click();
        }

        [Test]
        public void TheWhishListTest()
        {
            driver.Navigate().GoToUrl("https://magento.softwaretestingboard.com/");
            driver.FindElement(By.LinkText("Sign In")).Click();
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("testiranje1@testiranje.com");
            driver.FindElement(By.Id("pass")).Clear();
            driver.FindElement(By.Id("pass")).SendKeys("Testiranje1");
            driver.FindElement(By.XPath("//button[@id='send2']/span")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Id("ui-id-6")).Click();
            driver.FindElement(By.XPath("//a[contains(text(),'Bags')]")).Click();
            driver.FindElement(By.XPath("//img[@alt='Image']")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//main[@id='maincontent']/div[2]/div/div/div[5]/div/a/span")).Click();
            Thread.Sleep(5000);
        }

        [Test]
        public void TheShoppingCartDeleteTest()
        {
            driver.Navigate().GoToUrl("https://magento.softwaretestingboard.com/");
            driver.FindElement(By.LinkText("Sign In")).Click();
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("testiranje1@testiranje.com");
            driver.FindElement(By.Id("pass")).Clear();
            driver.FindElement(By.Id("pass")).SendKeys("Testiranje1");
            driver.FindElement(By.XPath("//button[@id='send2']/span")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//a[@id='ui-id-6']/span[2]")).Click();
            driver.FindElement(By.XPath("//a[contains(text(),'Bags')]")).Click();
            driver.FindElement(By.XPath("//img[@alt='Image']")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("product-addtocart-button")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Toggle Nav'])[1]/following::a[2]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//div[@id='minicart-content-wrapper']/div[2]/div[5]/div/a/span")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("Remove item")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.LinkText("here")).Click();
        }

        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
