using OpenQA.Selenium;

namespace DemoQA.Pages.WidgetsPages.AutoCompletePage
{
    public partial class AutoComplete : BasePage
    {

        public IWebElement InputedBar => 
            Driver.FindElement(By.XPath("//body/div[@id='app']/div/div/div/div/div[@id='autoCompleteContainer']/div/div/div[@id='autoCompleteSingle']/div[@id='autoCompleteSingleContainer']/div/div/div/div[1]"));
        public IWebElement InputBar => Driver.FindElement(By.XPath
            ("//body/div[@id='app']/div/div/div/div/div[@id='autoCompleteContainer']/div/div/div[@id='autoCompleteSingle']/div[@id='autoCompleteSingleContainer']/div/div[1]"));


    }
}
