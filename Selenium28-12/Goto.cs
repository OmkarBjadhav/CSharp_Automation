using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System.Xml.Linq;

namespace Selenium28_12
{
    public class Goto
    {
        public static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://www.goto.com/meeting/";
            // Console.WriteLine(driver.PageSource);
           
            driver.FindElement(By.XPath("//button[text()='Accept Recommended Settings']")).Click();
            Thread.Sleep(4000);
            IWebElement element = driver.FindElement(By.XPath("//a[text()='Try Free']"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(element).Click().Build().Perform();
          
            driver.FindElement(By.XPath("//label[text()='First Name']")).SendKeys("");
            driver.FindElement(By.XPath("//label[text()='Last Name']")).SendKeys("");
            driver.FindElement(By.XPath("//label[text()='Business Email']")).SendKeys("");
            driver.FindElement(By.XPath("//label[text()='Phone Number (Optional)']")).SendKeys("");
            SelectElement dropdown = new SelectElement (driver.FindElement(By.XPath("//select[@class='select__select  ']")));
            dropdown.SelectByText("10 - 99");



        }
    }
}
