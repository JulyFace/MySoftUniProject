//using DemoQA.Extentions;
//using DemoQA.Pages.WidgetsPages.AutoCompletePage;
//using NUnit.Framework;
//using OpenQA.Selenium;

//using System.Threading;

//namespace DemoQA.TESTS.WidgetsTESTS
//{
//    [TestFixture]
//    public class AutoCompleteTests : BaseTest
//    {
//        private AutoComplete _autoComplete;

//        [SetUp]
//        public void AutoSetUp()
//        {
//            Initialize();
//            _autoComplete = new AutoComplete(Driver);
//            _autoComplete.NavigateTo();

//        }



//        [TearDown]
//        public void TearDown()
//        {
//            Driver.Quit();
//        }

//        [Test]
//        public void ColorTextIsAutoCompleted_when_ColorFirstLetterInputed()
//        {

            
//            _autoComplete.InputBar.Click();

//            // ///var dropDownNavigation = Driver.FindElement(By.XPath("//body/div[@id='app']/div/div/div/div/div[@id='autoCompleteContainer']/div/div/div" + "[@id='autoCompleteMultiple']/div[@id='autoCompleteMultipleContainer']/div/div[1]"));

          
//           //     SendKeys("r" + Keys.Enter);






//            StringAssert.Contains("white green red ", _autoComplete.InputedBar.Text);
                

//        }


//    }
//}
