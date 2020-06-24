

using OpenQA.Selenium;

namespace DemoQA.Pages.AlertsFrameWindowPage.AlertsPage
{
    public partial class AlertsPage : BasePage
    {
        public IWebElement ButtonFirstRow => Driver.FindElement(By.XPath("//button[@id='alertButton']"));
        public IWebElement ButtonThirdRow => Driver.FindElement(By.CssSelector("#confirmButton"));
        public IWebElement AllertMessageButtonThurdRow => Driver.FindElement(By.XPath("//span[@id='confirmResult']"));




    }
}
