using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.WidgetsPages.AccordianPage
{
    public partial class AccordianPage : BasePage
    {

        public AccordianPage(IWebDriver driver): base(driver)
        {
                
        }

        public override string PageUrl => "http://www.demoqa.com/accordian";


        public void GetText(IWebElement element) 
        {
            element.ToString();
            
        
        
        }


    }
}
