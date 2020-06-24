using DemoQA.Extentions;
using DemoQA.Pages.HomePage;
using DemoQA.Pages.LeftPanel;
using NUnit.Framework;
using OpenQA.Selenium;

namespace DemoQA.TESTS.ElementsTESTS
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
            _homePage.HomePageSectionsButton("Elements").Click();

        }

        [Test]
        [TestCase("Text Box")]
        [TestCase("Check Box")]
        [TestCase("Radio Button")]
        [TestCase("Web Tables")]
        [TestCase("Buttons")]
        [TestCase("Links")]
        [TestCase("Upload and Download")]
        [TestCase("Dynamic Properties")]
       
       
        public void ElementsSectionsTest_when_ClickOn(string subName)
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
