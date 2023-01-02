using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace SeleniumAdvance
{
    public  class OpenEmr
    {
        [Test]
        public void Emr()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "http://demo.openemr.io/b/openemr/";
            driver.FindElement(By.CssSelector("#authUser")).SendKeys("admin");
            driver.FindElement(By.CssSelector("#clearPass")).SendKeys("pass");
            SelectElement sel = new SelectElement(driver.FindElement(By.XPath("//select[@name='languageChoice']")));
            sel.SelectByText("English (Indian)");
            driver.FindElement(By.CssSelector("#login-button")).Click();
            driver.FindElement(By.XPath("(//div[@aria-expanded='false'])[1]")).Click();
            driver.FindElement(By.XPath("(//div[@class='menuLabel px-1'])[6]")).Click();
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@name='pat']")));
            driver.FindElement(By.Id("form_fname")).SendKeys("jack");
            driver.FindElement(By.Id("form_lname")).SendKeys("scic");
           
        }
    }
}
