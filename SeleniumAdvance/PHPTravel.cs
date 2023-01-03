using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.Extensions;

namespace SeleniumAdvance
{
    public  class PHPTravel
    {
        [Test]
        public void Test()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://phptravels.net/";
            driver.FindElement(By.Id("flights-tab")).Click();
            driver.FindElement(By.XPath("//input[@id='autocomplete']")).SendKeys("LAX");
            driver.FindElement(By.XPath("//b[text()='LAX']")).Click();


            driver.FindElement(By.XPath("//input[@id='autocomplete2']")).SendKeys("DAL");
            driver.FindElement(By.XPath("//b[text()='DAL']")).Click();


            driver.ExecuteJavaScript(("document.querySelector('#departure').value='2022-05-30';"));

            driver.FindElement(By.XPath("(//p[text()='Travellers '])[2]")).Click();
           // driver.FindElement(By.XPath("//p[text()='Travellers ']")).Click();

            driver.FindElement(By.XPath("(//i[@class='la la-plus'])[5]")).Click();

            driver.FindElement(By.CssSelector("button#flights-search")).Click();





        }
    }
}
