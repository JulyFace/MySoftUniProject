using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.Pages.WidgetsPages.AccordianPage
{
    public partial class AccordianPage : BasePage
    {

        public void AssertTextInSection(string expected, string actual) 
        {

            StringAssert.Contains(expected,actual);
        
        }



    }
}
