using DemoQA.Pages.WidgetsPages.SelectMenuPage;
using NUnit.Framework;

namespace DemoQA.TESTS.WidgetsTESTS
{
    [TestFixture]
    public class SelectMenuTests : BaseTest
    {
        private SelectMenuPage _selectMenuPage;


        [SetUp]
        public void SetUp()
        {
            Initialize();
            _selectMenuPage = new SelectMenuPage(Driver);
            _selectMenuPage.NavigateTo();

        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

        [Test]
        public void FirstDropdownSelection_when_Option2IsSelected() 
        {
            var expectedText = "Group 2, option 2";

            _selectMenuPage.SelectValueBar.Click();
            _selectMenuPage.Group2Option2.Click();

            Assert.AreEqual(expectedText, _selectMenuPage.Group2Option2.Text);
        }
        [Test]
        public void SecondDropdownSelecttion_whenProfIsSelected()
        {
            var expextedText = "Prof.";

            _selectMenuPage.SelectOneBar.Click();
            _selectMenuPage.ProfSelection.Click();

            Assert.AreEqual(expextedText,_selectMenuPage.SelectOneBar.Text);




        }

    }

}