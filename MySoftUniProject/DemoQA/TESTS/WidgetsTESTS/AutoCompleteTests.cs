
using DemoQA.Pages.WidgetsPages.AutoCompletePage;
using NUnit.Framework;
using OpenQA.Selenium;

namespace DemoQA.TESTS.WidgetsTESTS
{
    [TestFixture]
    public class AutoCompleteTests : BaseTest
    {
        private AutoComplete _autoComplete;

        [SetUp]
        public void AutoSetUp()
        {
            Initialize();
            _autoComplete = new AutoComplete(Driver);
            _autoComplete.NavigateTo();

        }



        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

        [Test]
        public void ColorTextIsAutoCompleted_when_ColorFirstLetterInputed()
        {
            var gr = "g";

            Builder
               .ClickAndHold(_autoComplete.InputBar)
               .SendKeys(gr+Keys.ArrowDown+Keys.Enter)
               .Perform();
          
            StringAssert.Contains("Green", _autoComplete.InputBar.Text);

        }


    }
}
