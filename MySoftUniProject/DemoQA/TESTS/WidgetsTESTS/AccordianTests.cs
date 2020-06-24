using DemoQA.Extentions;
using DemoQA.Pages.WidgetsPages.AccordianPage;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoQA.TESTS.WidgetsTESTS.AccordianTests
{
    [TestFixture]
    public class AccordianTests : BaseTest
    {
        private AccordianPage _accordianPage;


        [SetUp]
        public void SetUp()
        {
            Initialize();
            _accordianPage = new AccordianPage(Driver);
            _accordianPage.NavigateTo();

        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();        
        }

        [Test]
        public void TextAssert_when_ClickedOnThurdSection() 
        {
            
            Driver.ScrollTo(_accordianPage.Section3WhyDoWeUseIt);

            _accordianPage.Section3WhyDoWeUseIt.Click();

            StringAssert.Contains("It is a long established fact that a", 
                _accordianPage.Section3Content.Text);

        }

        [Test]///////////////////////////////////////////////////////////////
        public void TextAssert_when_ClickedOnFirstSection()
        {

            Driver.ScrollTo(_accordianPage.Section3WhyDoWeUseIt);
            _accordianPage.Section3WhyDoWeUseIt.Click();

            _accordianPage.AssertTextInSection
                ("It is a long established fact that a", _accordianPage.Section3Content.Text);

        }





    }
}
