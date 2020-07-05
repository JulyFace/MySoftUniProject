using OpenQA.Selenium;


namespace DemoQA.Pages.WidgetsPages.SliderPage
{
    public partial class SliderPage : BasePage
    {
        public SliderPage(IWebDriver driver): base(driver)
        {


                
        }


        public override string PageUrl => "http://www.demoqa.com/slider";

       
    }
}
