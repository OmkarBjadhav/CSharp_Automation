using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium28_12
{
    public  class MediBuddy
    {
        public static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://www.medibuddy.in/";
            driver.FindElement(By.XPath("//a[text()='Login']")).Click();
            driver.FindElement(By.XPath("//div[@class ='coperate']")).Click();
            driver.FindElement(By.XPath("//div[@class ='coperate']")).Click();
            driver.FindElement(By.Name("userName")).SendKeys("john");
            driver.FindElement(By.XPath("//button[text() ='Proceed']")).Click();
            driver.FindElement(By.Name("password")).SendKeys("john123");
            driver.FindElement(By.XPath("//span[text() ='Show password']")).Click();
            driver.FindElement(By.XPath("//button[text() ='Log in']")).Click(); 




        }
    }
}
