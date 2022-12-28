using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcept
{
    public class Task3
    {
        //public static ChromeDriver IWebDriver { get; private set; }//

        public static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver();


            driver.Url = "https://www.salesforce.com/in/form/signup/freetrial-sales/";
            driver.FindElement(By.Name("UserFirstName")).SendKeys("abc");
            driver.FindElement(By.Name("UserLastName")).SendKeys("XYZ");
            driver.FindElement(By.Name("UserEmail")).SendKeys("abcxyz@gmail.com");

            SelectElement dropdown = new SelectElement(driver.FindElement(By.Name("UserTitle")));
            dropdown.SelectByValue("IT_Manager_AP");

            driver.FindElement(By.Name("CompanyName")).SendKeys("Maveric");
            driver.FindElement(By.Name("CompanyEmployees"));
            SelectElement dropdown1 = new SelectElement(driver.FindElement(By.Name("CompanyEmployees")));
            dropdown1.SelectByValue("250");

            driver.FindElement(By.Name("UserPhone")).SendKeys("095");
            //IWebElement  error=driver.FindElement(By.ClassName("error-msg"));
            //Console.WriteLine(error.Text);
            SelectElement dropdown2 = new SelectElement(driver.FindElement(By.Name("CompanyCountry")));
            dropdown2.SelectByText("Cameroon");

            driver.FindElement(By.ClassName("checkbox-ui")).Click();
            driver.FindElement(By.Name("start my free trial")).Click();
         // IWebElement  error=driver.FindElement(By.ClassName("error-msg-block"));
           // Console.WriteLine(error);

        }
    }
}
