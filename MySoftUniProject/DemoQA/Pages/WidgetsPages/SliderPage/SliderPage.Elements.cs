using OpenQA.Selenium;


namespace DemoQA.Pages.WidgetsPages.SliderPage
{
    public partial class SliderPage : BasePage
    {
        public IWebElement SliderBall => Driver.FindElement(By.XPath("//input[@class='range-slider range-slider--primary']"));
        public IWebElement SliderValueBar => Driver.FindElement(By.XPath("//input[@id='sliderValue']"));
        public IWebElement LeftPanel => Driver.FindElement(By.XPath("//div[contains(@class,'left-pannel')]"));
        


    }
}
