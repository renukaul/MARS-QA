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
            //Profile page object initializing and defining
            ProfilePage ProfilePageObj = new ProfilePage();
            ProfilePageObj.AddLanguage(driver);
        }

        [When(@"\[I want to add Skills details]")]
        public void WhenIWantToAddSkillsDetails()
        {
            ProfilePage ProfilePageObj = new ProfilePage();
            ProfilePageObj.AddSkills(driver);
        }

        [When(@"\[I want to add Education details]")]
        public void WhenIWantToAddEducationDetails()
        {
            ProfilePage ProfilePageObj = new ProfilePage();
            ProfilePageObj.AddEducation(driver);
        }

        [When(@"\[I want to add Certification details]")]
        public void WhenIWantToAddCertificationDetails()
        {
            ProfilePage ProfilePageObj = new ProfilePage();
            ProfilePageObj.AddCertification(driver);
        }

        [Then(@"\[The records should be created successfully]")]
        public void ThenTheRecordsShouldBeCreatedSuccessfully()
        {
            ProfilePage ProfilePageObj = new ProfilePage();

            string newLanguage = ProfilePageObj.GetLanguage(driver);
            string newSkill = ProfilePageObj.GetSkills(driver);
            string newEducation = ProfilePageObj.GetEducation(driver);
            string newCertification = ProfilePageObj.GetCertification(driver);

            Assert.That(newLanguage == "French", "Actual Language and Expected language does not match");
            Assert.That(newSkill == "Painting", "Actual Skill and Expected Skill does not match");
            Assert.That(newEducation == "AUT", "Actual Education and Expected Education does not match");
            Assert.That(newCertification == "Diploma", "Actual Certification and Expected Certification does not match");

        }
    }
}
