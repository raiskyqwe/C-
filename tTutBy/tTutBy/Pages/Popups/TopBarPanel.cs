﻿using Allure.Commons;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace tTutBy.Pages.Popups
{
    public class TopBarPanel : Page
    {
        [FindsBy(How = How.XPath, Using = "//div[@class='b-topbar-more active']")]
        [CacheLookup]
        private readonly IWebElement TopbarPanel;

        [FindsBy(How = How.XPath, Using = "//div[@class='b-topbar-more active']//li[@class='topbar__li mores']//a[@class='topbar__link']")]
        [CacheLookup]
        private readonly IWebElement AllSectionsButton;

        public TopBarPanel(IWebDriver driver) : base(driver) { }

        public bool IsTopBarPanelDisplayed()
        {
            if (TopbarPanel.Displayed)
                return true;
            else
                return false;
        }

        public ResourcePage AllSectionsButtonClick()
        {
            AllureLifecycle.Instance.RunStep("Open all sections(click to all sections button)", () =>
            {
                AllSectionsButton.Click();
            });

            return new ResourcePage(this.driver);
        }
    }
}
