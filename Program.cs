using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumTestTool
{
    class Program
    {
       
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            string link = @"https://www.google.com/";
            driver.Navigate().GoToUrl(link);


            //LOGIN BUTONU
            //driver.FindElement(By.ClassName("btnSignIn")).Click();
            //driver.FindElement(By.Id("email")).SendKeys("asasa@asasa.com");
            //driver.FindElement(By.Id("password")).SendKeys("asasasasa");
            //driver.FindElement(By.Id("loginButton")).Click();



            //driver.FindElement(By.ClassName("btnSignUp")).Click();
            //driver.FindElement(By.Id("firstName")).SendKeys("fadime");
            //driver.FindElement(By.Id("lastName")).SendKeys("açıkgöz");
            //driver.FindElement(By.Id("registrationEmail")).SendKeys("aaaaaa@aaaaaa.com");
            //driver.FindElement(By.Id("registrationPassword")).SendKeys("aaaaaaaaaaadd");
            //driver.FindElement(By.Id("passwordAgain")).SendKeys("aaaaaaaaaaadd");
            //driver.FindElement(By.Id("submitButton")).Click();


            //driver.FindElement(By.Id("searchData")).SendKeys("samsung");
            //driver.FindElement(By.ClassName("searchBtn")).Click();
            //driver.FindElement(By.XPath(".//*[@id='contentListing']/div/div/div[2]/div[4]/a[2]")).Click();
            //driver.FindElement(By.XPath(".//*[@id='p-269868647']/div[1]/a")).Click();
            // //driver.FindElement(By.ClassName("btnAddBasket")).Click();


            // driver.Manage().Window.Maximize();
            //driver.Manage().Timeouts().ım
            //    (TimeSpan.FromSeconds(10));

            //driver.FindElement(By.ClassName("inputtext")).SendKeys("sarikanarya66@outlook.com");
            //driver.FindElement(By.Id("pass")).SendKeys("Yeldakeremeslem66");
            //driver.FindElement(By.Id("loginbutton")).Click();
            ////driver.FindElement(By.XPath("//*[id='pagelet_welcome_box']/ul/li[1]/div/a")).Click();

            // driver.FindElement(By.Name("q")).SendKeys("merhabab");




        }
        
        
    
        }







    }
}
