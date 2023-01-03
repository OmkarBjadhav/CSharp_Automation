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
using OpenQA.Selenium.Interactions;

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


            //driver.FindElement(By.XPath("//div[@class='notification-banner__close']")).Click();
            driver.FindElement(By.XPath("//a[@id='rciHeaderSignIn']")).Click();
          //  driver.ExecuteJavaScript("document.getElementsByClassName('login__create-account login__create-account--royal');");
             IWebElement element= driver.FindElement(By.LinkText("Create an account"));
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].click();", element);
           
            driver.FindElement(By.XPath("//input[@data-placeholder='First name/Given name']")).SendKeys("Dennis");
            driver.FindElement(By.XPath("//input[@data-placeholder='Last name/Surname']")).SendKeys("Rich");

            driver.FindElement(By.XPath(" //span[text()='Month']")).Click();


            driver.FindElement(By.XPath("//span[normalize-space()='April']")).Click();

            driver.FindElement(By.XPath("//span[text()='Day']")).Click();
            driver.FindElement(By.XPath("//span[normalize-space()='4']")).Click();
            driver.FindElement(By.XPath("//input[@data-placeholder='Year']")).SendKeys("1990");


            driver.FindElement(By.XPath("//span[text()='Country/Region of residence']")).Click();
            Actions actions = new Actions(driver);
            actions.MoveToElement(driver.FindElement(By.XPath("//span[normalize-space()='India']"))).Perform();
            driver.FindElement(By.XPath("//span[normalize-space()='India']")).Click();


            driver.FindElement(By.XPath("//input[@data-placeholder='Email address']")).SendKeys("abcd@gamil.com");
            driver.FindElement(By.XPath("//input[@data-placeholder='Create new password']")).SendKeys("Welcome@123");
           // driver.FindElement(By.XPath("//span[normalize-space()='Select one security question']")).Click();
           // driver.FindElement(By.XPath("//span[normalize-space()='What was your first car's make or model?']")).Click();
            //driver.FindElement(By.XPath("//input[@data-placeholder='Answer']")).SendKeys("Old Street oval");


            driver.FindElement(By.XPath("//span[normalize-space()='Select one security question']")).Click();
            actions.MoveToElement(driver.FindElement(By.XPath("//span[@class='mat-select-min-line ng-tns-c51-22 ng-star-inserted']"))).Perform();
            driver.FindElement(By.XPath("//span[@class='mat-select-min-line ng-tns-c51-22 ng-star-inserted']")).Click();

           

            //  sel1.SelectByText("4");

            //  driver.FindElement(By.CssSelector("#mat-input-3")).SendKeys("1990");





        }

    }
}
