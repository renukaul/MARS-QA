using MARS_QA.Pages;
using MARS_QA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using SeleniumExtras.PageObjects;

namespace MARS_QA.StepDefinitions 
{
    [Binding]
    public class ProfilefeatureStepDefinitions : CommonDriver
    {


        //Add and review Language details

        [Given(@"\[I log in to the MAR QA website successfully]")]
        public void GivenILogInToTheMARQAWebsiteSuccessfully()
        {
            //Open chromedriver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/");

            var HomePage = new HomePage();
            PageFactory.InitElements(driver, HomePage);
            HomePage.signInButton.Click();

            var Loginpage = new Loginpage();
            PageFactory.InitElements(driver, Loginpage);
            Loginpage.Loginsteps();
            

        }

        [When(@"\[I want to add Language details]")]
        public void WhenIWantToAddLanguageDetails()
        {
           // Profile page object initializing and defining
            var Language = new Language();
            PageFactory.InitElements(driver, Language);

            Language.addLanguage(driver);
          
        }

        
              
        [Then(@"\[The records should be created successfully]")]
        public void ThenTheRecordsShouldBeCreatedSuccessfully()
        {
            Language Languagepageobj = new Language();

            string newLanguage = Languagepageobj.GetLanguage(driver);
            Assert.That(newLanguage == "French", "Actual Language and Expected language does not match");

                       
        }




        //Add and review Skills details

        [Given(@"\[I log in to the MAR QA website for add skills]")]
        public void GivenILogInToTheMARQAWebsiteForAddSkills()
        {
            //Open chromedriver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/");

            var HomePage = new HomePage();
            PageFactory.InitElements(driver, HomePage);
            HomePage.signInButton.Click();

            var Loginpage = new Loginpage();
            PageFactory.InitElements(driver, Loginpage);
            Loginpage.Loginsteps();

        }

        [When(@"\[I want to add Skillls details]")]
        public void WhenIWantToAddSkilllsDetails()
        {
            var Skills = new Skills();
            PageFactory.InitElements(driver, Skills);

            Skills.AddSkills(driver);
        }

        [Then(@"\[The skills records should be created successfully]")]
        public void ThenTheSkillsRecordsShouldBeCreatedSuccessfully()
        {
            Skills Skillspageobj = new Skills();
            string newSkill = Skillspageobj.GetSkills(driver);
            Assert.That(newSkill == "Painting", "Actual Skill and Expected Skill does not match");
        }




        //Add and review Education details

        [Given(@"\[I log in to the MAR QA website to add education details]")]
        public void GivenILogInToTheMARQAWebsiteToAddEducationDetails()
        {
            //Open chromedriver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/");

            var HomePage = new HomePage();
            PageFactory.InitElements(driver, HomePage);
            HomePage.signInButton.Click();

            var Loginpage = new Loginpage();
            PageFactory.InitElements(driver, Loginpage);
            Loginpage.Loginsteps();
        }

        [When(@"\[I want to add the Education details]")]
        public void WhenIWantToAddTheEducationDetails()
        {
            var Education = new Education();
            PageFactory.InitElements(driver, Education);
            Education.addEducation(driver);
        }

        [Then(@"\[The education records should be created successfully]")]
        public void ThenTheEducationRecordsShouldBeCreatedSuccessfully()
        {
            Education Educationpageobj = new Education();
            string newEducation = Educationpageobj.GetEducation(driver);
            Assert.That(newEducation == "AUT", "Actual Education and Expected Education does not match");
        }





        //Add and review Certification details

        [Given(@"\[I log in to the MAR QA website to add Certification details]")]
        public void GivenILogInToTheMARQAWebsiteToAddCertificationDetails()
        {
            //Open chromedriver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/");

            var HomePage = new HomePage();
            PageFactory.InitElements(driver, HomePage);
            HomePage.signInButton.Click();

            var Loginpage = new Loginpage();
            PageFactory.InitElements(driver, Loginpage);
            Loginpage.Loginsteps();
        }

        [When(@"\[I want to add the Certification details]")]
        public void WhenIWantToAddTheCertificationDetails()
        {
            var Certification = new Certification();
            PageFactory.InitElements(driver, Certification);
            Certification.AddCertification(driver);
        }

        [Then(@"\[The Certification records should be created successfully]")]
        public void ThenTheCertificationRecordsShouldBeCreatedSuccessfully()
        {
            Certification Certificationpageobj = new Certification();
            string newCertification = Certificationpageobj.GetCertification(driver);
            Assert.That(newCertification == "Diploma", "Actual Certificate and Expected Certificate does not match");
        }


    }

}
