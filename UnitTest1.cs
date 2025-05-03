using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;



namespace AzurePipeLine
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://www.saucedemo.com/v1/");
            Thread.Sleep(3000);
            webDriver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            Thread.Sleep(3000);
            webDriver.FindElement(By.XPath("//*[@id='password']")).SendKeys("secret_sauce");
            Thread.Sleep(3000);
            webDriver.FindElement(By.Id("login-button")).Click();
            Thread.Sleep(3000);
           
            webDriver.Quit();

        }

    }

}
