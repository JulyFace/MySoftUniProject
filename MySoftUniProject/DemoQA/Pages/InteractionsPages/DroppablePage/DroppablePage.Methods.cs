using DemoQA.Pages;
using OpenQA.Selenium;


namespace DemoQA.Pages.InteractionsPages.DroppablePage
{
    public partial class DroppablePage : BasePage
    {

        public DroppablePage(IWebDriver driver)
         : base(driver)
        {

        }

       public override string PageUrl => "http://demoqa.com/droppable";


    }
}
