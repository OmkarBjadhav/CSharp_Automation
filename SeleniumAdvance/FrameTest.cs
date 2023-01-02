using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAdvance
{
    public class FrameTest
    {
        [Test]
        public void Demo1Frame()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://netbanking.hdfcbank.com/netbanking/";
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//frame[@name='login_page']")));
            driver.FindElement(By.XPath("//input[@name='fldLoginUserId']")).SendKeys("kevin123");
            driver.FindElement(By.LinkText("CONTINUE")).Click();


        }

        public void Demo2Alert()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://netbanking.hdfcbank.com/netbanking/IpinResetUsingOTP.htm";

        }
        }
}
