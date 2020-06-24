using DemoQA.Extentions;
using DemoQA.Pages.HomePage;
using DemoQA.Pages.LeftPanel;
using NUnit.Framework;
using OpenQA.Selenium;

namespace DemoQA.TESTS.WidgetsTESTS
{
    public class ElementsLeftPanelTests : BaseTest
    {

        private HomePage _homePage;
        private LeftPanel _leftPanelPage;
       


        [SetUp]
        public void SetUp()
        {

            Initialize();
            _homePage = new HomePage(Driver);
            _leftPanelPage = new LeftPanel(Driver);
            _homePage.NavigateTo();
            _homePage.HomePageSectionsButton("Widgets").Click();

        }

        [Test]
        [TestCase("Accordian")]
        [TestCase("Auto Complete")]
        [TestCase("Date Picker")]
        [TestCase("Slider")]
        [TestCase("Progress Bar")]
        [TestCase("Tabs")]
        [TestCase("Tool Tips")]
        [TestCase("Menu")]
        [TestCase("Select Menu")]
       
        public void WidgetsSectionsTest_when_ClickOn(string subName)
        {
            
            var dropDownNavigation = Driver.FindElement(By.XPath($"//*[normalize-space(text())='{subName}']"));

            Driver.ScrollTo(dropDownNavigation);
            _leftPanelPage.SubMenu(subName).Click();


            _leftPanelPage.AssertPageTitle(subName);


        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }



    }
}
