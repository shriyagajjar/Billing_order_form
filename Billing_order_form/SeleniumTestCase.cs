using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Billing_order_form.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class SeleniumTestCase
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [TearDown]
        public void TeardownTest()
        {

            driver.Quit();
        }

        [Test]
        public void TC1()
        {
            driver.Navigate().GoToUrl("http://qaauto.co.nz/billing-order-form/");
            driver.FindElement(By.Id("wpforms-24-field_0")).SendKeys("shri");
            driver.FindElement(By.Id("wpforms-24-field_0-last")).SendKeys("fdghj");
            driver.FindElement(By.Id("wpforms-24-field_1")).SendKeys("dsfghj@gmail.com");
            driver.FindElement(By.Id("wpforms-24-field_3")).SendKeys("ftyghjn");
            driver.FindElement(By.Id("wpforms-24-field_3-address2")).SendKeys("fghnm");
            driver.FindElement(By.Id("wpforms-24-field_3-city")).SendKeys("rdtfghjb");
            new SelectElement(driver.FindElement(By.Id("wpforms-24-field_3-state"))).SelectByText("Idaho");
            driver.FindElement(By.Id("wpforms-24-field_6")).SendKeys("fghjkl");

        }

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();

        }
        [Test]
        public void TC2()
        {
            BillingOrderPage billingOrderPage = new BillingOrderPage(driver);
            billingOrderPage.NavigateTO();
            billingOrderPage.FirstName("shri");
            billingOrderPage.LastName("fdghj");
            billingOrderPage.Email("sfghj@gmail.com");
            billingOrderPage.Phone("ftyghjn");
            billingOrderPage.AddressLine1("fghnm");
            billingOrderPage.City("rdtfghjb");
            billingOrderPage.State("Idaho");
            billingOrderPage.Comment("fghjkl");


        }
    }
}
