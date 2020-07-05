using OpenQA.Selenium;


namespace DemoQA.Pages.WidgetsPages.SelectMenuPage
{
    public partial class SelectMenuPage : BasePage
    {
        public SelectMenuPage(IWebDriver driver): base(driver)
        {}

        public override string PageUrl => "http://www.demoqa.com/select-menu";

    }
}
