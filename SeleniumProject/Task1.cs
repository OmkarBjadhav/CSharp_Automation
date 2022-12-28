using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcept
{
    public class Task1
    {
        public static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://parabank.parasoft.com/parabank/register.htm";
            Console.WriteLine(driver.Title);
            driver.FindElement(By.Id("customer.firstName")).SendKeys("Rahul");
            driver.FindElement(By.Id("customer.lastName")).SendKeys("Bindra");
            driver.FindElement(By.Id("customer.address.street")).SendKeys("Near Taj Hotel");
            driver.FindElement(By.Id("customer.address.city")).SendKeys("Mumbai");
            driver.FindElement(By.Id("customer.address.state")).SendKeys("Maharashtra");
            driver.FindElement(By.Id("customer.address.zipCode")).SendKeys("412623");
            driver.FindElement(By.Id("customer.phoneNumber")).SendKeys("8975423293");
            driver.FindElement(By.Id("customer.ssn")).SendKeys("843630479898");
            driver.FindElement(By.Id("customer.username")).SendKeys("Rahul@123");
            driver.FindElement(By.Id("customer.password")).SendKeys("Bindra@123");
            driver.FindElement(By.Id("repeatedPassword")).SendKeys("Bindra@123");
            driver.FindElement(By.XPath("//input[@class='button'and @value='Register']")).Click();



        }//
    }
}
