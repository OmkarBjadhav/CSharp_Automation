using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAdvance
{
    public  class UploadFile
    {
        [Test]
        public void Test()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://www.adobe.com/in/acrobat/online/convert-pdf.html";
            driver.FindElement(By.XPath("//span[text()='Convert']")).Click();
            driver.FindElement(By.XPath("//span[text()='PDF to JPG']")).Click();
            driver.FindElement(By.XPath("//button[@id='lifecycle-nativebutton']")).
                SendKeys(@"C:\Users\omkarj\Desktop\New folder\Mine.Pdf.pdf");



        }

    }
}
