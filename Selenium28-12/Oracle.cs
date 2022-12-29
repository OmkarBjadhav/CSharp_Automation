using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium28_12
{
    public  class Oracle
    {
        public static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://www.oracle.com/in/database/";
            driver.FindElement(By.XPath("//span[text()='View Accounts']")).Click();
            driver.FindElement(By.XPath("//a[text()='Sign-In']")).Click();
            Console.WriteLine("The Title of the page: "+driver.Title);
            Console.WriteLine("The url of the current page: "+driver.Url);

            //IWebElement text=driver.FindElement(By.XPath("(//div[@class='cb41w1'])[2]"));
            //Console.WriteLine(" Page Title"+text.Text);

            driver.FindElement(By.XPath("//input[@name='ssousername']")).SendKeys("john");
            driver.FindElement(By.XPath("//input[@name='password']")).SendKeys("john123");
            driver.FindElement(By.XPath("//input[@class='sign-in-button']")).Click();


            IWebElement text2 = driver.FindElement(By.XPath("(//div[@class='cb41error'])[2]"));
            Console.WriteLine(" Error message after invalid username and password:  "+text2.Text);



        }
    }
}
