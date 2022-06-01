using MARS_QA.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MARS_QA.Pages
{
    internal class ProfilePage
    {

        public void AddLanguage(IWebDriver driver)
        {
            //Add New Language skill

            //Identify and click the Add new button
            IWebElement addNewButton = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewButton.Click();
            Thread.Sleep(1000);
            //Identify Add new language box and enter valid language details
            IWebElement addNewLanguage = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            addNewLanguage.Click();
            Thread.Sleep(500);
            addNewLanguage.SendKeys("French");
            //Identify Choose language level drop down button and select the language level
            IWebElement languageLevelDropdown = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
                       
            Wait.WaitForvisible(driver, "Xpath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select", 2);

            languageLevelDropdown.Click();


            IWebElement languageLevelOption = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[2]"));

            Wait.WaitForvisible(driver, "Xpath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[2]", 2);
            languageLevelOption.Click();
            //Identify and click the add button
            IWebElement addButton = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addButton.Click();

            //

        }
        public string GetLanguage(IWebDriver driver)
        {
            IWebElement languageTab = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a.item.active"));
            Wait.Waitforclicable(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a.item.active");
            languageTab.Click();
           
            IWebElement actualLanguage = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td:nth-child(1)"));
            Wait.WaitForvisible(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td:nth-child(1)",2);
            //Thread.Sleep(1000);
            return actualLanguage.Text;

        }

        public void AddSkills(IWebDriver driver)
        {
            //Identify Skills Tab and click it

            IWebElement skillTab = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillTab.Click();
            //Identify Addnew button and click
            
            IWebElement addNewSkillbutton = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > thead > tr > th.right.aligned > div"));

            Wait.Waitforclicable(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > thead > tr > th.right.aligned > div", 2);

            addNewSkillbutton.Click();

            //Identify Add Skill box and enter valid skill details
            IWebElement addSkill = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(1) > input[type=text]"));
            Thread.Sleep(1000);
            addSkill.SendKeys("Painting");
            //Identify and click skill level dropdown button and select the skill level
            IWebElement skillLevelDropdown = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > select"));
            Wait.Waitforclicable(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > select", 2);

            skillLevelDropdown.Click();

           // Wait.WaitForvisible(driver, "Xpath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select", 2);

            IWebElement skillLevelOption = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > select"));
            Wait.WaitForvisible(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > select", 2);
            skillLevelOption.Click();
            Thread.Sleep(1000);


            IWebElement skillLevelType = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > select > option:nth-child(3)"));
            Wait.Waitforclicable(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > select > option:nth-child(3)");
            
            skillLevelType.Click();
            //Identify and click the skill Add button
            IWebElement skillAddButton = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > span > input.ui.teal.button"));
            Wait.Waitforclicable(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > span > input.ui.teal.button");

            skillAddButton.Click();


        }

        public string GetSkills(IWebDriver driver)
        {
            IWebElement skillTab = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a.item.active"));
            Wait.Waitforclicable(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a.item.active");
            skillTab.Click(); 
            
            IWebElement actualSkill = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td:nth-child(1)"));
            Thread.Sleep(1000);           
            return actualSkill.Text;

        }
               
        public void AddEducation(IWebDriver driver)
        {

            //Identify Education Tab and click it

            IWebElement educationTab = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            Wait.Waitforclicable(driver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]", 2);
            educationTab.Click();
            
            //Identify and click the add new button
            IWebElement educationAddnewbutton = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            educationAddnewbutton.Click();


            //Identify and input the college details
            IWebElement collegeUniName = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
            Thread.Sleep(1000);
            collegeUniName.SendKeys("AUT");
            
            //Identify country dropdown box and select the country
            IWebElement countryDropdown = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
            Wait.WaitForclicable(driver, "Xpath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select",2);
            countryDropdown.Click();

            IWebElement countryOption = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[102]"));
            Wait.Waitforclicable(driver, "Xpath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[102]", 2);
            countryOption.Click();
            Thread.Sleep(1000);


            //Identify the graduate title and select the title option
            IWebElement titleDropdown = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[6]"));
            Wait.WaitForclicable(driver, "Xpath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[6]", 2);
            titleDropdown.Click();
            
            IWebElement titleOption = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > div:nth-child(1) > select > option:nth-child(6)"));
            Wait.Waitforclicable(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > div:nth-child(1) > select > option:nth-child(6)", 2);
            titleDropdown.Click();


            //Identify the degree qualification box and enter valid details
            IWebElement degreeQualification = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
            Thread.Sleep(1000);
            degreeQualification.SendKeys("Degree");


            //Identify the year of graduation and select the details
            IWebElement yearOfGraduationdropdown = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));
            Wait.WaitForclicable(driver, "Xpath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select",2);
            yearOfGraduationdropdown.Click();
            
            IWebElement yearOfGraduationoption = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[9]"));
            Wait.WaitForclicable(driver, "Xpath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[9]",2);
            yearOfGraduationoption.Click();
            
            
            //Identify and click the education Add button
            IWebElement addEducationbutton = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            Wait.Waitforclicable(driver, "Xpath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]", 2);
            addEducationbutton.Click();


        }

        public string GetEducation(IWebDriver driver)

        {
            IWebElement actualEducationUni = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td:nth-child(2)"));
            Wait.WaitForvisible(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td:nth-child(2)", 2);
            return actualEducationUni.Text;

        }


        public void AddCertification(IWebDriver driver)
        {

            //Identify Certification Tab and click it

            IWebElement certificationTab = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a:nth-child(4)"));
            Wait.Waitforclicable(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a:nth-child(4)");
            certificationTab.Click();


            //Identify Addnew certification button and click
            IWebElement addNewCertification = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > div > table > thead > tr > th.right.aligned > div"));
            Wait.Waitforclicable(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > div > table > thead > tr > th.right.aligned > div");
            addNewCertification.Click();
            Thread.Sleep(1000);


            //Identify Add certification box and enter valid certification details
            IWebElement addCertificationAward = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > div > div > div:nth-child(1) > div > input"));
            Thread.Sleep(1000);
            addCertificationAward.SendKeys("Diploma");

            //Identify and add the certified from box
            IWebElement certifiedFrom = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > div.eight.wide.field > input"));
            Thread.Sleep(1000);
            certifiedFrom.SendKeys("AUT");

            
            //Identify and select the year of achievement 


            IWebElement yearDropdown = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > div.three.wide.field > select"));
            Wait.Waitforclicable(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > div.three.wide.field > select");
            yearDropdown.Click();

            IWebElement yearOption = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > div.three.wide.field > select > option:nth-child(4)"));
            Wait.Waitforclicable(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > div.three.wide.field > select > option:nth-child(4)");
            yearOption.Click();



            //Identify and click the Certification Add button
            IWebElement certificationAddButton = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > div > div > div.five.wide.field > input.ui.teal.button"));
            Wait.Waitforclicable(driver, "CssSelctor", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > div > div > div.five.wide.field > input.ui.teal.button");
            certificationAddButton.Click();


        }

        public string GetCertification(IWebDriver driver)
        {
            IWebElement actualCertificate = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td:nth-child(1)"));
            return actualCertificate.Text;

        }
    }
}


    
