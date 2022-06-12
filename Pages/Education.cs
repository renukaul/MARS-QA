using MARS_QA.Utilities;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MARS_QA.Pages
{
    public class Education
    {
        //Identify Education Tab
        [FindsBy(How=How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]")]
        public IWebElement educationTab { get; set; }

        //Identify and click the add new button
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div")]
        public IWebElement educationAddnewbutton { get; set; }

        //Identify and input the college details
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input")]
        public IWebElement collegeUniName { get; set; }

        //Identify country dropdown box and select the country
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select")]
        public IWebElement countryDropdown { get; set; }

       
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[102]")]
        public IWebElement countryOption { get; set; }


        //Identify the graduate title and select the title option
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[6]")]
        public IWebElement titleDropdown { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > div:nth-child(1) > select > option:nth-child(6)")]
        public IWebElement titleOption { get; set; }
        
        
        //Identify the degree qualification box and enter valid details
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input")]
        public IWebElement degreeQualification { get; set; }


        //Identify the year of graduation and select the details

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select")]
        public IWebElement yearOfGraduationdropdown { get; set; }


        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[9]")]
        public IWebElement yearOfGraduationoption { get; set; }

        //Identify and click the education Add button

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]")]
        public IWebElement addEducationbutton { get; set; }


        public void addEducation(IWebDriver driver)
        {

            Wait.WaitForclicable(driver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]", 2);
            educationTab.Click();

            Wait.WaitForclicable(driver,"XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div", 2);
            educationAddnewbutton.Click();

            Wait.WaitForvisible(driver,"XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input",2);
            collegeUniName.SendKeys("AUT");

            Wait.WaitForclicable(driver, "Xpath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select", 2);
            countryDropdown.Click();

            Wait.Waitforclicable(driver, "Xpath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[102]", 2);
            countryOption.Click();

            Wait.WaitForclicable(driver, "Xpath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[6]", 2);
            titleDropdown.Click();

            Wait.Waitforclicable(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > div:nth-child(1) > select > option:nth-child(6)", 2);
            titleOption.Click();

            Wait.WaitForvisible(driver, "Xpath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input", 2);
            degreeQualification.SendKeys("Degree");

            Wait.WaitForclicable(driver, "Xpath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select", 2);
            yearOfGraduationdropdown.Click();

            Wait.WaitForclicable(driver, "Xpath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[9]", 2);
            yearOfGraduationoption.Click();

            Wait.Waitforclicable(driver, "Xpath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]", 2);
            addEducationbutton.Click();

        }

        public string GetEducation(IWebDriver driver)

        {
            IWebElement actualEducationUni = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td:nth-child(2)"));
            Wait.WaitForvisible(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td:nth-child(2)", 2);
            return actualEducationUni.Text;

        }

    }
}
