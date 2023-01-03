using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;

namespace SeleniumAdvance
{
    public class ActionsDemo
    {
        [Test]
        public void NasscomTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://nasscom.in/#login-btn";

            driver.FindElement(By.XPath("//button[@class='fancybox-button fancybox-button--close']")).Click();
            Actions act = new Actions(driver);
            act.MoveToElement(driver.FindElement(By.XPath("//a[text()='Membership']"))).Perform();
            driver.FindElement(By.LinkText("Members Listing")).Click();


        }

        [Test]
        public void NasscomTest2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://nasscom.in/#login-btn";
            driver.FindElement(By.XPath("//button[@class='fancybox-button fancybox-button--close']")).Click();
            Actions act = new Actions(driver);
            act.MoveToElement(driver.FindElement(By.XPath("//a[text()='Membership']"))).Perform();
           act.MoveToElement(driver.FindElement(By.XPath("//a[text()='Become a Member']"))).Build().Perform();
            driver.FindElement(By.LinkText("Membership Benefits")).Click();   

        }

        [Test]
        public void KeyBoardAct()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://www.google.com/";
            Actions act = new Actions(driver);
            act.KeyDown(Keys.Shift).SendKeys("hello World").KeyUp(Keys.Shift).Pause(TimeSpan.FromSeconds(2))
                .SendKeys(Keys.ArrowDown).SendKeys(Keys.ArrowDown).SendKeys(Keys.ArrowDown).Pause(TimeSpan.FromSeconds(2))
                .SendKeys(Keys.Enter).Build().Perform();    


        }
    }
}
