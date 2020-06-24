using OpenQA.Selenium;


namespace DemoQA.Pages.WidgetsPages.AccordianPage
{
    public partial class AccordianPage : BasePage
    {
        public IWebElement Section3WhyDoWeUseIt => Driver.FindElement(By.XPath("//div[contains(text(),'Why do we use it?')]"));
        public IWebElement Section3Content => Driver.FindElement(By.XPath("//p[contains(text(),'It is a long established fact that a reader will b')]"));

       






    }
}
