using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace Billing_order_form

{
    public class OrderForm
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://qaauto.co.nz/billing-order-form/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Openformtest()
        {
            //enter password
            //enter password
            driver.FindElement(By.Id("wpforms-locked-24-field_form_locker_password")).SendKeys("Testing");
            driver.FindElement(By.Name("wpforms[submit]")).Click();

            //wait
           // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            //enter name
            driver.FindElement(By.Id("wpforms-24-field_0")).SendKeys("SHRI");
            driver.FindElement(By.CssSelector("#wpforms-24-field_0-last")).SendKeys("GAJJAR");

            //email
            driver.FindElement(By.Id("wpforms-24-field_1")).SendKeys("SHRI@gmail.com");

            //phone
            driver.FindElement(By.Name("wpforms[fields][2]")).SendKeys("1234567890");

            //Address
            driver.FindElement(By.CssSelector("#wpforms-24-field_3")).SendKeys("7,abcd");
            driver.FindElement(By.CssSelector("#wpforms-24-field_3-city")).SendKeys("XYZ");
            driver.FindElement(By.CssSelector("#wpforms-24-field_3-postal")).SendKeys("133855236");

            SelectElement state = new SelectElement(driver.FindElement(By.Id("wpforms-24-field_3-state")));
            state.SelectByText("California");

            //Available items
            driver.FindElement(By.Id("wpforms-24-field_4_2")).Click();

            //total amount
            string totalamount = driver.FindElement(By.XPath("//div[contains(text(),'$ 20.00')]")).Text;
            Assert.AreEqual(totalamount,"$ 20.00");

            //comment or message
            driver.FindElement(By.TagName("textarea")).SendKeys("hellooo");

            //submit
            driver.FindElement(By.CssSelector("#wpforms-submit-24")).Click();


            //close 
            driver.Navigate().GoToUrl("http://qaauto.co.nz/test-blank-form/");

            driver.FindElement(By.Id("wpforms-locked-16-field_form_locker_password")).SendKeys("Testing");
            driver.FindElement(By.Name("wpforms[submit]")).Click();

            driver.FindElement(By.Id("wpforms-16-field_0")).SendKeys("SHRI");
            driver.FindElement(By.Id("wpforms-16-field_0-last")).SendKeys("GAJJAR");

            //email
            driver.FindElement(By.Id("wpforms-16-field_1")).SendKeys("SHRI@gmail.com");

            driver.FindElement(By.Id("wpforms-16-field_2")).SendKeys("asdfvgbhnjmkjh");

            driver.FindElement(By.Name("wpforms[submit]")).Click();
        }
    }
}