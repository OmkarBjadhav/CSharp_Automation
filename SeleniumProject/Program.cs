using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcept
{
    public class Program
    {
         static void Main(string[] args)
        {//
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Url = "https://github.com/login";
            
                

            Console.WriteLine(driver.Title);

            Console.WriteLine(driver.Url);
            // Console.WriteLine(driver.PageSource);
            driver.FindElement(By.Id ("login_field")).SendKeys("Abc@gmail.com");
            driver.FindElement(By.Id("password")).SendKeys("Abcd");
            driver.FindElement(By.Name("commit")).Click();
            driver.FindElement(By.Id ("login_field")).Clear();    



        }
    }
}
