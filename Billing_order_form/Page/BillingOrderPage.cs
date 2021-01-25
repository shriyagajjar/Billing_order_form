using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Billing_order_form.Page
{
    class BillingOrderPage
    {
        IWebDriver driver;
        
        public BillingOrderPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void NavigateTO()
        {
            driver.Navigate().GoToUrl("http://qaauto.co.nz/billing-order-form/");
        }

        public void FirstName(string value)
        {
            driver.FindElement(By.Id("wpforms-24-field_0")).SendKeys(value);
        }
        public void LastName(string value)
        {
            driver.FindElement(By.Id("wpforms-24-field_0-last")).SendKeys(value);
        }
        public void Email(string value)
        {
            driver.FindElement(By.Id("wpforms-24-field_1")).SendKeys(value);
        }
        public void Phone(string value)
        {
            driver.FindElement(By.Id("wpforms-24-field_3")).SendKeys(value);
        }
        public void AddressLine1(string value)
        {
            driver.FindElement(By.Id("wpforms-24-field_3-address2")).SendKeys(value);
        }
        public void City(string value)
        {
            driver.FindElement(By.Id("wpforms-24-field_3-city")).SendKeys(value);
        }
        public void State(string value)
        {
            new SelectElement(driver.FindElement(By.Id("wpforms-24-field_3-state"))).SelectByText(value);

        }
        public void Comment(string value)
        {
            driver.FindElement(By.Id("wpforms-24-field_6")).SendKeys(value);
        }
       
    }
}
