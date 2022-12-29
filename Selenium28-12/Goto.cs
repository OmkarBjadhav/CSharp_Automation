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
           
            driver.FindElement(By.Id("truste-consent-button")).Click();
            
           
            
            Actions act = new Actions(driver);
            try
            {
                act.ScrollToElement(driver.FindElement(By.LinkText("Try Free"))).Perform();
            }
            catch 
            { 
            
            }
            //act.ScrollToElement(driver.FindElement(By.LinkText("Try Free"))).Perform();
            Thread.Sleep(3000);
            driver.FindElement(By.LinkText("Try Free")).Click();
        

            driver.FindElement(By.Id("first-name")).SendKeys("john");
            driver.FindElement(By.Id("last-name")).SendKeys("Wick");
            driver.FindElement(By.Id("login__email")).SendKeys("abc@gmail.com");
            //driver.FindElement(By.XPath("//label[text()='Phone Number (Optional)']")).SendKeys("8234724128");

            SelectElement dropdown = new SelectElement (driver.FindElement(By.XPath("//select[@class='select__select  ']")));
            dropdown.SelectByText("10 - 99");
            driver.FindElement(By.Id("contact-number")).SendKeys("1A");
            driver.FindElement(By.XPath("//button[text()='Start My Trial']")).Click();
            string err=driver.FindElement(By.XPath("//div[@class='inputField__requirements']")).Text;
            Console.WriteLine(err);



        }
    }
}
