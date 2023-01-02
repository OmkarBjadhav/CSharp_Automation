using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace Maveric.SubscriptionTest
{
    public  class SubscriptionTest
    {
        [Test]
        public void AddSubscriptionTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://www.automationworld.com/";
            driver.FindElement(By.XPath("//div[@class='close-olytics-image-bottom-midpurple']")).Click();
            driver.FindElement(By.XPath("//span[text()='Subscribe'and @class='site-navbar__label']")).Click();
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            driver.FindElement(By.CssSelector("#id24_344")).Click();

            driver.FindElement(By.XPath("//input[@name='demo59703']")).SendKeys("John");
            driver.FindElement(By.XPath("//input[@name='demo59704']")).SendKeys("weak");
            driver.FindElement(By.XPath("//input[@name='demo59705']")).SendKeys("Test Associate");
           //// driver.FindElement(By.CssSelector("//input[@name='demo59706']")).SendKeys("");
            driver.FindElement(By.XPath("//input[@name='demo59707']")).SendKeys("www.maveric.com");
            driver.FindElement(By.XPath("//input[@name='demo59708']")).SendKeys("Maveric Systems");
            driver.FindElement(By.XPath("//input[@name='demo59709']")).SendKeys("02822-27379233");

            SelectElement sel = new SelectElement(driver.FindElement(By.XPath("//select[@name='demo59710']")));
            sel.SelectByText("INDIA");

            driver.FindElement(By.XPath("//input[@name='demo59713']")).SendKeys("Chennai");
            driver.FindElement(By.CssSelector("#id339_2327")).Click();
            driver.FindElement(By.XPath("//input[@type='submit']")).Click();
           string msg =driver.FindElement(By.XPath("//li[contains(text(),'Email Address is required.')]")).Text;
            Console.WriteLine(msg); 




        }
    }
}
