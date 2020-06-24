using DemoQA.Pages;
using OpenQA.Selenium;

namespace DemoQA.Pages.InteractionsPages.ResizablePage
{
    public partial class ResizablePage : BasePage
    {

        public ResizablePage(IWebDriver driver):base(driver)
        {


        }

        public override string PageUrl => "http://www.demoqa.com/resizable";

    }
}
