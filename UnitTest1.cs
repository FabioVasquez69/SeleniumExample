using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Threading;
using System;
namespace SeleniumExample
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");
            IWebDriver driver = new ChromeDriver(@"C:\Users\FABIO\source\repos\SeleniumExample", options);
            
            driver.Url = "https://www.google.com";
            driver.FindElement(By.Name("q")).SendKeys("Celsia");
            Thread.Sleep(20000);
           // driver.FindElement(By.CssSelector("[name=btnK]")).Click();
            driver.FindElement(By.XPath("//a[@href='https://www.celsia.com/es/']")).Click();
            //driver.Quit();
        }
    }
}
