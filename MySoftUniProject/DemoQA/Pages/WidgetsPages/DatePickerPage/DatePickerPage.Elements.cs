using OpenQA.Selenium;


namespace DemoQA.Pages.WidgetsPages.DatePickerPage
{
    public partial class DatePickerPage : BasePage
    {
        public IWebElement DateBar => Driver.FindElement(By.XPath("//input[@id='datePickerMonthYearInput']"));
        public IWebElement MonthPickerJuly => Driver.FindElement(By.XPath("//[@id='datePickerMonthYearInput']"));
        









    }
}
