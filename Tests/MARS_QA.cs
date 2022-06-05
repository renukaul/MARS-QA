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
            LanguageTab LanguageTabObj = new LanguageTab();
            LanguageTabObj.AddLanguage(driver);
        }

        [Test]
        public void AddSkills()
        {
            SkillTab SkillTabObj = new SkillTab();
            SkillTabObj.AddSkills(driver);
        }
        
        [Test]
        public void AddEducation()
        {
            EducationTab EducationTabObj = new EducationTab();
            EducationTabObj.AddEducation(driver);
        }
        [Test]
        public void AddCertification()
        {
         //   CertificationTab CertificationTabObj = new CertificationTab();
         //   CertificationTabObj.AddCertification(driver);
        }

        
    }
}
