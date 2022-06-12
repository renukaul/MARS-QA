using MARS_QA.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARS_QA.Utilities 
{
    
   public class CommonDriver
   {
        public static IWebDriver driver;

        [OneTimeSetUp]
        public void LoginFunctions()
        {
            //Open chromedriver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //Login page object initializing and defining
            Loginpage LoginPageObj = new Loginpage();
         //   LoginPageObj.LoginSteps(driver);
        }

        [OneTimeTearDown]
        public void CloseTestrun()
        {
            driver.Quit();
        }


    }

    
}
