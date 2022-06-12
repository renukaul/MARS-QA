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
    internal class Language
    {
        
        //Identify and click the Add new button
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")]
        public IWebElement addNewButton { get; set; }

         
        //Identify Add new language box and enter valid language details
        [FindsBy(How = How.XPath, Using = "/ html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input")]
        public IWebElement addNewLanguage { get; set; }

        //Identify Choose language level drop down button and select the language level
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select")]
        public IWebElement languageLevelDropdown { get; set; }

        //Language level Option
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[2]")]
        public IWebElement languageLevelOption { get; set; }

        //Identify and click the add button
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]")]
        public IWebElement addButton { get; set; }

      

        public void addLanguage(IWebDriver driver)
        {
            Wait.WaitForclicable(driver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div", 2);
            addNewButton.Click();
            Thread.Sleep(1000);

            Wait.WaitForvisible(driver, "XPath", "/ html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input", 2);
            addNewLanguage.SendKeys("French");

            Wait.WaitForclicable(driver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select", 2);
            languageLevelDropdown.Click();

            Wait.WaitForclicable(driver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[2]", 2);
            languageLevelOption.Click();

            Wait.WaitForclicable(driver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]", 2);
            addButton.Click();
        }

               
        public string GetLanguage(IWebDriver driver)
        {
            IWebElement languageTab = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a.item.active"));
            Wait.Waitforclicable(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a.item.active",2);
            languageTab.Click();

            IWebElement actualLanguage = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody:last-child > tr > td:nth-child(1)"));
            Wait.WaitForvisible(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody:last-child > tr > td:nth-child(1)", 2);

            return actualLanguage.Text;

        }


        /*
        //Edit button
        [FindsBy(How =How.XPath, Using = "//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i")]
        public IWebElement editButton { get; set; }

        //Edit Language txtbox
        [FindsBy (How = How.XPath, Using = "//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr/td/div/div[1]/input")]
        public IWebElement editLanguagetxtbox { get; set; }

        //Edit Language Level
        [FindsBy(How = How.XPath, Using = "//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr/td/div/div[2]/select")]
        public IWebElement languageLevelEdit;

        //Update button
        [FindsBy(How = How.XPath, Using = "//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr/td/div/span/input[1]")]
        public IWebElement updateLanguage;

        //Delete Button
        [FindsBy(How = How.XPath, Using = "//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i")]
        public IWebElement deleteButton;
      */
        /*  public void editEducation(IWebDriver driver)
          {
              Wait.WaitForclicable(driver, "XPath", "//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i", 2);
              editButton.Click();

              Wait.WaitForclicable(driver, "XPath", "//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr/td/div/div[1]/input", 2);
              editLanguagetxtbox.Click();
              editLanguagetxtbox.Clear();
              editLanguagetxtbox.SendKeys("Italian");

              Wait.WaitForvisible(driver, "XPath", "//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr/td/div/div[2]/select", 2);
              languageLevelEdit.SendKeys("Basic");

              Wait.WaitForclicable(driver, "XPath", "//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr/td/div/span/input[1]", 2);
              updateLanguage.Click();

          }
          public void deleteEducation(IWebDriver driver)
          {

              Wait.WaitForclicable(driver, "XPath", "//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i", 2);
              deleteButton.Click();

          }*/

    }
}
