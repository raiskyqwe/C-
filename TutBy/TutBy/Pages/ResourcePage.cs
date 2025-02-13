﻿using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace TutBy.Pages
{
    public class ResourcePage : Page
    {
        [FindsBy(How = How.XPath, Using = "//a[@class='header-logo']")]
        [CacheLookup]
        private readonly IWebElement Logo;

        [FindsBy(How = How.XPath, Using = "//div[@class='l-col main-content inner-page-content']//div[@class='l-col-i']")]
        [CacheLookup]
        private readonly IWebElement PortalSections;

        public ResourcePage(IWebDriver driver) : base(driver) { }
        
        public HomePage LogoClick()
        {
            Logo.Click();

            return new HomePage(this.driver);
        }

        public bool IsPortalSectionsDisplayed()
        {
            if (PortalSections.Displayed)
                return true;
            else
                return false;
        }
    }
}
