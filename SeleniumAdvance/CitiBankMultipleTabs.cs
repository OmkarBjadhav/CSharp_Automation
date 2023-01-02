using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace SeleniumAdvance
{
    public  class CitiBankMultipleTabs
    {
        [Test]
        public void CitiBankTabs()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://www.online.citibank.co.in/";

            driver.FindElement(By.XPath("//a[@title='Close']")).Click();
            driver.FindElement(By.XPath("//span[text()='Login']")).Click();
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            driver.FindElement(By.XPath("//div[text()=' Forgot User ID? ']")).Click();
            // Actions act = new Actions(driver);
            // act.ScrollToElement(driver.FindElement(By.XPath("//a[text()='Privacy']"))).Perform();
            driver.FindElement(By.LinkText("select your product type")).Click();
            driver.FindElement(By.XPath("//a[text()='Credit Card']")).Click();

            driver.FindElement(By.Id("citiCard1")).SendKeys("4545");
            driver.FindElement(By.Id("citiCard2")).SendKeys("5656");
            driver.FindElement(By.Id("citiCard3")).SendKeys("8887");
            driver.FindElement(By.Id("citiCard4")).SendKeys("9998");

            driver.FindElement(By.Id("cvvnumber")).SendKeys("070");

            driver.FindElement(By.Id("bill-date-long")).Click();
            SelectElement sel = new SelectElement(driver.FindElement(By.XPath("//select[@class='ui-datepicker-month']")));
            sel.SelectByText("Apr");
            driver.FindElement(By.XPath("//a[text()='14']")).Click();

            driver.FindElement(By.XPath("//input[@value='PROCEED']")).Click();
            string msg=driver.FindElement(By.XPath("")).Text;
            Console.WriteLine("The Final Msg"+msg);



        }
    }
}
