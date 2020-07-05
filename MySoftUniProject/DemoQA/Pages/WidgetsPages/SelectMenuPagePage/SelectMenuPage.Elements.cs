using OpenQA.Selenium;


namespace DemoQA.Pages.WidgetsPages.SelectMenuPage
{
    public partial class SelectMenuPage : BasePage
    {
        public IWebElement SelectValueBar  => Driver.FindElement(By.XPath("//div[@id='withOptGroup']//div[contains(@class,'css-tlfecz-indicatorContainer')]//*[local-name()='svg']//*[name()='path' and contains(@d,'M4.516 7.5')]"));
        public IWebElement Group2Option2 => Driver.FindElement(By.XPath("//div[contains(text(),'Group 2, option 2')]"));
        
        public IWebElement SelectOneBar => Driver.FindElement(By.CssSelector("#selectOne > div > div.css-1hwfws3"));


        public IWebElement ProfSelection => Driver.FindElement(By.XPath("//div[contains(text(),'Prof.')]"));
        
        //public IWebElement  => Driver.FindElement(By.XPath(""));
       
    }
}
