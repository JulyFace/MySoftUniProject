using DemoQA.Extentions;
using DemoQA.Pages.HomePage;
using DemoQA.Pages.LeftPanel;
using NUnit.Framework;
using OpenQA.Selenium;

namespace DemoQA.TESTS.AlertsFrameWindowsTESTS
{
    public class AlertsFrameWinLeftPanelTests : BaseTest
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
            _homePage.HomePageSectionsButton("Alerts, Frame & Windows").Click();

        }

        [Test]
        [TestCase("Browser Windows")]
        [TestCase("Alerts")]
        [TestCase("Frames")]
        [TestCase("Modal Dialogs")]
        
        public void AlertsFrameWindowsSectionsTest_when_ClickOn(string subName)
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
