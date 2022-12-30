using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAdvance
{
    public class MultipleTabsTest
    {
        [Test]
        public void PhpMyAdminTabTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://www.db4free.net/";
            driver.FindElement(By.PartialLinkText("phpMyAdmin")).Click();
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            driver.FindElement(By.Id("input_username")).SendKeys("john");
            driver.FindElement(By.Id("input_password")).SendKeys("admin");
            driver.FindElement(By.Id("input_go")).Click();
            driver.Close();
           
            //Console.WriteLine(driver.Title);
            // Console.WriteLine("Omkara");
        }
    }
}
