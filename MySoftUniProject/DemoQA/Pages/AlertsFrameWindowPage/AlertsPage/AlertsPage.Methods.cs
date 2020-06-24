using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.AlertsFrameWindowPage.AlertsPage
{
    public partial class AlertsPage : BasePage
    {
        public AlertsPage(IWebDriver driver) : base(driver)
        {
                
        }

        public override string PageUrl => "http://www.demoqa.com/alerts";

    }
}
