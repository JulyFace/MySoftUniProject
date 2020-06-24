using OpenQA.Selenium;

namespace DemoQA.Pages.InteractionsPages.DraggablePage
{
    public partial class DraggablePage : BasePage
    {
        public DraggablePage(IWebDriver driver) : base(driver)
        {

        }


        public override string PageUrl => "http://www.demoqa.com/dragabble";

    }
}
