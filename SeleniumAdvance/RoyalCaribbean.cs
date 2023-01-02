using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.Extensions;
using System.Xml.Linq;

namespace SeleniumAdvance
{
    public  class RoyalCaribbean
    {
        [Test]
        public void Royal()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://www.royalcaribbean.com/";
            driver.FindElement(By.XPath("(//a[@class='headerSignIn__link' ])[1]")).Click();
          //  driver.ExecuteJavaScript("document.getElementsByClassName('login__create-account login__create-account--royal');");
             IWebElement element= driver.FindElement(By.LinkText("Create an account"));
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].click();", element);
           
            driver.FindElement(By.CssSelector("#mat-input-3")).SendKeys("Dennis");
            driver.FindElement(By.CssSelector("#mat-input-4")).SendKeys("Rich");

            SelectElement sel = new SelectElement(driver.FindElement(By.XPath(" //div[@class='mat-select-arrow ng-tns-c51-15']")));
            sel.SelectByText("April");

            SelectElement sel1 = new SelectElement(driver.FindElement(By.XPath("(//span[text()='Day'])[1]")));
            sel1.SelectByText("4");

            driver.FindElement(By.CssSelector("#mat-input-3")).SendKeys("1990");



        }

    }
}
