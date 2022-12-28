using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace SeleniumConcept
{
    public  class Task2
    {
        public static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://demo.guru99.com/test/newtours/register.php";
            Console.WriteLine(driver.Title);
            driver.FindElement(By.Name("firstName")).SendKeys("Abc");
            driver.FindElement(By.Name("lastName")).SendKeys("Xyz");
            driver.FindElement(By.Name("phone")).SendKeys("9488487434");
            driver.FindElement(By.Id("userName")).SendKeys("Abcdsfh");//
            driver.FindElement(By.Name("address1")).SendKeys("maumbai");
            driver.FindElement(By.Name("city")).SendKeys("pune");
            driver.FindElement(By.Name("state")).SendKeys("maharashtra");
            driver.FindElement(By.Name("postalCode")).SendKeys("380738");


            SelectElement dropdown1 = new SelectElement(driver.FindElement(By.Name("country")));
            dropdown1.SelectByValue("INDIA");


            driver.FindElement(By.Name("email")).SendKeys("Abc@gamil.com");
            driver.FindElement(By.Name("password")).SendKeys("fla39873jsfl");
            driver.FindElement(By.Name("confirmPassword")).SendKeys("la39873jsfl");
            driver.FindElement(By.ClassName("checkbox-ui")).Click();



        }
    }
}
