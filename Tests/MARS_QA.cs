using MARS_QA.Pages;
using MARS_QA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace MARS_QA
{   [TestFixture]
    internal class MARS_QA : CommonDriver
    {
        
        [Test]
        public void AddLanguage()
        {
            //Profile page object initializing and defining
            ProfilePage ProfilePageObj = new ProfilePage();
            ProfilePageObj.AddLanguage(driver);
        }

        [Test]
        public void AddSkills()
        {
            ProfilePage ProfilePageObj = new ProfilePage();
            ProfilePageObj.AddSkills(driver);
        }
        
        [Test]
        public void AddEducation()
        {
            ProfilePage ProfilePageObj = new ProfilePage();
            ProfilePageObj.AddEducation(driver);
        }
        [Test]
        public void AddCertification()
        {
            ProfilePage ProfilePageObj = new ProfilePage();
            ProfilePageObj.AddCertification(driver);
        }

        
    }
}
