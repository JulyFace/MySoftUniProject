using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.WidgetsPages.DatePickerPage
{
    public partial class DatePickerPage : BasePage
    {
        public DatePickerPage(IWebDriver driver): base(driver)
        {


                
        }


        public override string PageUrl => "http://www.demoqa.com/date-picker";

       
    }
}
