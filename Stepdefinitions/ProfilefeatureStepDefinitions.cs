using MARS_QA.Pages;
using MARS_QA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

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

            //Login page object initializing and defining
            Loginpage LoginPageObj = new Loginpage();
            LoginPageObj.LoginSteps(driver);
        }

        [When(@"\[I want to add Language details]")]
        public void WhenIWantToAddLanguageDetails()
        {
           // Profile page object initializing and defining
            ProfilePage ProfilePageObj = new ProfilePage();
            ProfilePageObj.AddLanguage(driver);
        }

        
              
        [Then(@"\[The records should be created successfully]")]
        public void ThenTheRecordsShouldBeCreatedSuccessfully()
        {
            ProfilePage ProfilePageObj = new ProfilePage();

            string newLanguage = ProfilePageObj.GetLanguage(driver);
            Assert.That(newLanguage == "French", "Actual Language and Expected language does not match");

                       
        }




        //Add and review Skills details

        [Given(@"\[I log in to the MAR QA website for add skills]")]
        public void GivenILogInToTheMARQAWebsiteForAddSkills()
        {
            //Open chromedriver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //Login page object initializing and defining
            Loginpage LoginPageObj = new Loginpage();
            LoginPageObj.LoginSteps(driver);
        }

        [When(@"\[I want to add Skillls details]")]
        public void WhenIWantToAddSkilllsDetails()
        {
            ProfilePage ProfilePageObj = new ProfilePage();
            ProfilePageObj.AddSkills(driver);
        }

        [Then(@"\[The skills records should be created successfully]")]
        public void ThenTheSkillsRecordsShouldBeCreatedSuccessfully()
        {
            ProfilePage ProfilePageObj = new ProfilePage();
            string newSkill = ProfilePageObj.GetSkills(driver);
            Assert.That(newSkill == "Painting", "Actual Skill and Expected Skill does not match");
        }




        //Add and review Education details

        [Given(@"\[I log in to the MAR QA website to add education details]")]
        public void GivenILogInToTheMARQAWebsiteToAddEducationDetails()
        {
            //Open chromedriver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //Login page object initializing and defining
            Loginpage LoginPageObj = new Loginpage();
            LoginPageObj.LoginSteps(driver);
        }

        [When(@"\[I want to add the Education details]")]
        public void WhenIWantToAddTheEducationDetails()
        {
            ProfilePage ProfilePageObj = new ProfilePage();
            ProfilePageObj.AddEducation(driver);
        }

        [Then(@"\[The education records should be created successfully]")]
        public void ThenTheEducationRecordsShouldBeCreatedSuccessfully()
        {
            ProfilePage ProfilePageObj = new ProfilePage();
            string newEducation = ProfilePageObj.GetEducation(driver);
            Assert.That(newEducation == "AUT", "Actual Education and Expected Education does not match");
        }





        //Add and review Certification details

        [Given(@"\[I log in to the MAR QA website to add Certification details]")]
        public void GivenILogInToTheMARQAWebsiteToAddCertificationDetails()
        {
            //Open chromedriver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //Login page object initializing and defining
            Loginpage LoginPageObj = new Loginpage();
            LoginPageObj.LoginSteps(driver);
        }

        [When(@"\[I want to add the Certification details]")]
        public void WhenIWantToAddTheCertificationDetails()
        {
            ProfilePage ProfilePageObj = new ProfilePage();
            ProfilePageObj.AddCertification(driver);
        }

        [Then(@"\[The Certification records should be created successfully]")]
        public void ThenTheCertificationRecordsShouldBeCreatedSuccessfully()
        {
            ProfilePage ProfilePageObj = new ProfilePage();
            string newCertification = ProfilePageObj.GetCertification(driver);
            Assert.That(newCertification == "Diploma", "Actual Certificate and Expected Certificate does not match");
        }


    }

}
