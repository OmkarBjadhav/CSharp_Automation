using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace SeleniumAdvance
{
    public  class RedBus
    {
        [Test]
        public void Demo()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://www.redbus.in/";
            driver.FindElement(By.CssSelector("#sign-in-icon-down")).Click();
            driver.FindElement(By.CssSelector("#signInLink")).Click();
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@class='modalIframe']")));
           // driver.SwitchTo().Frame(driver.WindowHandles[4]);
            driver.FindElement(By.Id("mobileNoInp")).SendKeys("7859");
            string Msg = driver.FindElement(By.XPath("//span[contains(text(),'Please enter ')]")).Text;
            Console.WriteLine(Msg); 
           // Console.WriteLine(driver.WindowHandles[1]);

        }
    }
}
