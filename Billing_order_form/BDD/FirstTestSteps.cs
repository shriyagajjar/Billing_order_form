using Billing_order_form.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Billing_order_form.BDD
{
    [Binding]
    public class FirstTestSteps
    {
        int firstnumber;
        int secondnumber;
        int actualresult;
        int sum;

        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int p0)
        {
            firstnumber = p0;  
        }
        
        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int p0)
        {
            secondnumber = p0;
        }
        
        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            actualresult = firstnumber + secondnumber;
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int expectedResult)
        {
            Assert.AreEqual(expectedResult, actualresult);
        }

        IWebDriver driver;
        BillingOrderPage billingOrderPage;

        [Given(@"i am on Billingorder page")]
        public void GivenIAmOnBillingorderPage()
        {
            driver = new ChromeDriver();
            billingOrderPage = new BillingOrderPage(driver);
            billingOrderPage.NavigateTO();
        }

        [When(@"i enter firstname")]
        public void WhenIEnterFirstname()
        {
            billingOrderPage.FirstName("shri");

        }

        [When(@"i enter lastname")]
        public void WhenIEnterLastname()
        {
            billingOrderPage.LastName("fdghj");

        }

        [Then(@"it should calculate bill")]
        public void ThenItShouldCalculateBill()
        {
        }
    }
}
