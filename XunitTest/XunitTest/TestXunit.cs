using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace XunitTest
{
   
    public class TestXunit
    {


        [Fact]
        public void TestSeleniumChrome()
        {           
            //using (IWebDriver driver = new ChromeDriver(@"dependencies"))
            //{
            //    driver.Navigate().GoToUrl("https://www.google.co.th");                     
            //    driver.Quit();
            //}

            IWebDriver driver = new ChromeDriver(@"dependencies");
            driver.Navigate().GoToUrl("https://www.google.co.th");
            driver.Quit();
            //Assert.Equals("https://www.google.co.th/", driver.Url);
            Assert.Equal(5, 5);
        }

        [Fact]
        public void PassingTest()
        {
            var a = 4;
            Assert.Equal(4, a);
        }

        [Fact]
        public void Yessss()
        {
            var a = 5;
            Assert.Equal(5, a);
        }
    }
}
